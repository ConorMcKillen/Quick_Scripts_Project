﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace QSProject.Helpers
{
    [HtmlTargetElement(Attributes = "asp-condition")] 
    public class ConditionTagHelper : TagHelper
    {
        [HtmlAttributeName("asp-condition")]
        public bool Condition { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition)
            {
                output.SuppressOutput();
            }
        }
    }
}
