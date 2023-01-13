using CoreUygulamam.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreUygulamam.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Yusuf"
                },
                new UserComment
                {
                    ID=2,
                    Username="Hayat"
                },
                new UserComment
                {
                    ID =3,
                    Username="Ahmet"
                }
            };
            return View(commentvalues);
        }
    }
}
