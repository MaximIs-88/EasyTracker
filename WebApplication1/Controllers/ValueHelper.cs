using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication1.Controllers
{
    
    public class ValueHelper : ITagHelper
    {
        public void Init(TagHelperContext context)
        {
            throw new NotImplementedException();
        }

        public Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            throw new NotImplementedException();
        }

        public int Order { get; }
    }
}
