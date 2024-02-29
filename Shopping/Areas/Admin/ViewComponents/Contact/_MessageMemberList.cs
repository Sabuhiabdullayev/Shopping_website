﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Areas.Admin.ViewComponents.Contact
{
    public class _MessageMemberList:ViewComponent
    {
        UserManager<AppUser> _userManager;
        Context _context;

        public _MessageMemberList(UserManager<AppUser> userManager, Context context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var value = _context.Users.ToList();
            return View(value);
        }
    }
}
