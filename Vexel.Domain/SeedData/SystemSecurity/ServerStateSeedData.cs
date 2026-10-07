using System.Collections.Generic;
using Vexel.Code;
using Vexel.DataBase;

namespace Vexel.Domain.SystemSecurity
{
    /// <summary>
    /// ´´ ½¨£º³¬¼¶¹ÜÀíÔ±
    /// ÈÕ ÆÚ£º2024-07-19 19:42
    /// Ãè Êö£º¶¨Ê±ÈÎÎñÖÖ×Ó
    /// </summary>
    public class ServerStateSeedData : ISqlSugarEntitySeedData<ServerStateEntity>
    {
        [IgnoreSeedDataUpdate]
        public IEnumerable<ServerStateEntity> SeedData()
        {
            var data = "";
            return data.ToObject<List<ServerStateEntity>>();
        }
    }
}