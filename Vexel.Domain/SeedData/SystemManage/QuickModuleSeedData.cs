using System.Collections.Generic;
using Vexel.Code;
using Vexel.DataBase;

namespace Vexel.Domain.SystemManage
{
    /// <summary>
    /// ´´ ½¨£º³¬¼¶¹ÜÀíÔ±
    /// ÈÕ ÆÚ£º2024-07-19 19:42
    /// Ãè Êö£º¿ì½Ý²Ëµ¥ÖÖ×Ó
    /// </summary>
    public class QuickModuleSeedData : ISqlSugarEntitySeedData<QuickModuleEntity>
    {
        [IgnoreSeedDataUpdate]
        public IEnumerable<QuickModuleEntity> SeedData()
        {
            var data = "";
            return data.ToObject<List<QuickModuleEntity>>();
        }
    }
}