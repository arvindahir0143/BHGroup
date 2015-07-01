using BHGroupEntity;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using BHGroupEntity.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using Utilities;

namespace BHGroupBAL
{
   public class DrowTokenBAL
    {
        #region Get Methods
        public string GetGridData(GridSettings grid)
        {
            try
            {
                using (var ctx = new BHGroupEntities())
                {
                    var query = ctx.DrowTokens.Include("Member").AsQueryable();

                    int count;
                    var data = query.GridCommonSettings(grid, out count);

                    var result = new
                    {
                        total = (int)Math.Ceiling((double)count / grid.PageSize),
                        page = grid.PageIndex,
                        records = count,
                        rows = (from p in data
                                select new
                                {
                                    id = p.DrowTokenId,
                                    Name = p.Member.Name,
                                    Status = p.Status,
                                    Creaton = p.Creaton,
                                    Action = p.DrowTokenId
                                }).ToArray()
                    };
                    return JsonConvert.SerializeObject(result, new IsoDateTimeConverter());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DrowToken GetById(int id)
        {
            try
            {
                using (var ctx = new BHGroupEntities())
                {
                    return ctx.DrowTokens.Where(p => p.DrowTokenId == id).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
