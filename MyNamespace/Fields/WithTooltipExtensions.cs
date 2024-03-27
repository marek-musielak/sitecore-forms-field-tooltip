using System.Web;

namespace MyAssembly.MyNamespace.Fields
{
    public static class WithTooltipExtensions
    {
        public static HtmlString Tooltip(this IWithTooltip fieldWithTooltip)
        {
            var tooltip = fieldWithTooltip.TooltipText;

            if (!string.IsNullOrEmpty(tooltip))
            {
                tooltip = $"<span title=\"{HttpUtility.HtmlEncode(tooltip)}\">&#x24D8;</span>";
            }

            return new HtmlString(tooltip);
        }
    }
}