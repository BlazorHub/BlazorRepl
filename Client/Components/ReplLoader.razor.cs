﻿namespace BlazorRepl.Client.Components
{
    using Microsoft.AspNetCore.Components;

    public partial class ReplLoader : ComponentBase
    {
        [Parameter]
        public bool Show { get; set; }

        [Parameter]
        public string Message { get; set; }
    }
}
