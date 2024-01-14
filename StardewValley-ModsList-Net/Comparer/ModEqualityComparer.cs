using StardewValleyModList.DataModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace StardewValleyModList.Comparer
{
    public class ModEqualityComparer : IEqualityComparer<ModsDataModel>
    {
        public bool Equals([DisallowNull] ModsDataModel current, [DisallowNull] ModsDataModel target)
        {
            if (current.Name.Equals(target.Name)) return true;
            return false;
        }

        public int GetHashCode([DisallowNull] ModsDataModel obj)
        {
            if (obj is null) return 0;
            return obj.Name.GetHashCode();
        }
    }
}
