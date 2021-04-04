using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace PrettyBlazorDemo.Pages
{
    public partial class Index : ComponentBase
    {
        public List<int> Numbers { get; set; } =
            Enumerable.Range(start: 0, count: 10).ToList();
    }
}
