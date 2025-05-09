﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class MenuDAO
    {

        NConnect db = null;

        public MenuDAO()
        {
            db = new NConnect();
        }

        public List<MENU> ListMenu()
        {
            return db.MENUs.Where(x => x.TrangThai == 2).OrderBy(x => x.ID).ToList();
        }
    }
}
