using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSelect
{
    public class SelectBase : ComponentBase,IDisposable
    {
        public String Name { get; set; }

        public void Dispose()
        {
            Console.WriteLine($"{Name} Dispose");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
           // Console.WriteLine($"{Name} OnAfterRender");
        }
        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            //Console.WriteLine($"{Name} OnAfterRenderAsync firstRender={firstRender}");
            return base.OnAfterRenderAsync(firstRender);
        }
        protected override void OnInitialized()
        {
            //Console.WriteLine("\n***********************************");
           // Console.WriteLine($"{Name} OnInitialized");
            base.OnInitialized();
        }
        protected override Task OnInitializedAsync()
        {
            //Console.WriteLine("\n***********************************");
            //Console.WriteLine($"{Name} OnInitializedAsync");
            return base.OnInitializedAsync();
        }
        protected override void OnParametersSet()
        {
            //Console.WriteLine($"{Name} OnParametersSet");
            base.OnParametersSet();
        }
        protected override Task OnParametersSetAsync()
        {
            //Console.WriteLine($"{Name} OnParametersSetAsync");
            return base.OnParametersSetAsync();
        }
        public override Task SetParametersAsync(ParameterView parameters)
        {
            //Console.WriteLine($"{Name} SetParametersAsync");
            //foreach (var p in parameters)
            //{
            //    Console.WriteLine($"     {p.Name} = {p.Value}");
            //}
            return base.SetParametersAsync(parameters);
        }
        protected override bool ShouldRender()
        {
            //Console.WriteLine($"{Name} ShouldRender");
            return base.ShouldRender();
        }
        
    }
}
