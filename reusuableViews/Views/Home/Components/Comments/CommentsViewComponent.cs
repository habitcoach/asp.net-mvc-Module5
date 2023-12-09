using System;
using Microsoft.AspNetCore.Mvc;

namespace reusuableViews.Views.Home.Components.Comments
{
	
	

    public class CommentsViewComponent : ViewComponent

    {

        public async Task<IViewComponentResult> InvokeAsync()

        {

            var model = new List<string>() {

              "Here’s a comment.",

              "Another comment.",

              "Comment spam..."

              };

            return View(model);

        }

    }



}

