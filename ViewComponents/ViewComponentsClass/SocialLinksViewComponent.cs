using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;

namespace ViewComponents.ViewComponentsClass
{
    public class SocialLinksViewComponent : ViewComponent
    {
        List<SocialIcon> socialIcons = new List<SocialIcon>();
        public SocialLinksViewComponent()
        {
            socialIcons = SocialIcon.AppSocialIcons();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = socialIcons;
            return await Task.FromResult((IViewComponentResult)View("SocialLinkIcon", model));//Setting the View component name other than default
        }
    }
}
