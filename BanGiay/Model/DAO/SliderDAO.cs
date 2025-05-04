using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.DAO
{
    public class SliderDAO
    {
        NConnect db = null;
        public SliderDAO()
        {
            db = new NConnect();
        }

        public List<SLIDE> GetListActive()
        {
            return db.SLIDEs.Where(x => x.TrangThai == 2).OrderByDescending(x => x.ID).ToList();
        }
    }
}
