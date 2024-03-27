using Sitecore;
using Sitecore.Data.Items;
using Sitecore.ExperienceForms.Mvc.Models.Fields;

namespace MyAssembly.MyNamespace.Fields
{
    public class StringInputViewModelWithTooltip : StringInputViewModel, IWithTooltip
    {
        public string TooltipText { get; set; }

        protected override void InitItemProperties(Item item)
        {
            base.InitItemProperties(item);
            TooltipText = StringUtil.GetString(item.Fields["Tooltip Text"]);
        }

        protected override void UpdateItemFields(Item item)
        {
            base.UpdateItemFields(item);
            item.Fields["Tooltip Text"]?.SetValue(TooltipText, false);
        }
    }
}
