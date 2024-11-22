using System;
using System.Linq.Dynamic.Core;
using DoctorAppointment.Domain.Entities.Base;
using DoctorAppointment.Domain.Specification;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Infrastructure.Data;

public static class GetQuery<TEntity> where TEntity : EntityBase
{
    public static IQueryable<TEntity> From(IQueryable<TEntity> query, ISpecification<TEntity>? specification = null)
    {
        if (specification == null)
            return query;
        
        // Check tracking
        query = specification.IsNoTracking ? query.AsNoTracking() : query.AsTracking();
        
        // Ignore query filters
        if (specification.IsIgnoreQueryFilters)
            query = query.IgnoreQueryFilters();

        // Filtering
        query = specification.Filters.Aggregate(
            query, 
            (current,
            filter) => current.Where(filter));

        // Include related data
        query = specification.Includes.Aggregate(
            query,
            (current,
            include) => current.Include(include));

        query = specification.IncludeStrings.Aggregate(
            query,
            (current,
            include) => current.Include(include));
        
        // Searching
        if (!string.IsNullOrWhiteSpace(specification.SearchTerm))
        {
            var searchClause = string.Empty;
            foreach (var searchField in specification.SearchFields)
            {
                searchClause += searchClause == string.Empty ? string.Empty : " || ";
                searchClause += $"{searchField} != null && {searchField}.ToLower().Contains(\"{specification.SearchTerm}\")";
            }
            query = query.Where(searchClause);
        }

        // Ordering
        if (specification.OrderByField != null)
            query = specification.IsDescending
                        ? query.OrderBy(specification.OrderByField + " desc")
                        : query.OrderBy(specification.OrderByField);

        // if(specification.Skip > 0)
        //     query = query.Skip(specification.Skip);
        // if(specification.Take > 0)
        //     query = query.Take(specification.Take);
        
        return query;

    }
}