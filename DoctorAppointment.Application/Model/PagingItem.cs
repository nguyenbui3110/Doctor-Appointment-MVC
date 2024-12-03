using System;

namespace DoctorAppointment.Application.Model;

public class PagingItem<T> : IPagingItem
{
    public int pageSize { get; set; } = 8;
    public List<T> Items { get; set; }
    public int CurrentPage { get; set; }
    public int CountPages { get; set; }
    // public SearchModel SearchModel { get; set; }

    public Func<int, string> PageUrl { get; set; } = i => $"?page={i}";


}
