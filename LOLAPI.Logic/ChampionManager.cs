using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOLAPI.Shared.Interfaces;
using LOLAPI.Shared.Entities;
using LOLAPI.Data;
namespace LOLAPI.Logic
{
    public class ChampionManager : IChampionManager
    {

        private LoLDBContext _lolDBContext = new LoLDBContext();
        private static readonly string gncRiotApiKey;

        static ChampionManager()
        {
            gncRiotApiKey = "c92b6d81-20ff-438c-a966-503fa839c3e5";
        }

        public List<Champion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Champion GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public Champion Add(Champion item)
        {
            throw new NotImplementedException();
        }

        public Champion EditById(Champion item, int id)
        {
            throw new NotImplementedException();
        }

        public Champion DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
