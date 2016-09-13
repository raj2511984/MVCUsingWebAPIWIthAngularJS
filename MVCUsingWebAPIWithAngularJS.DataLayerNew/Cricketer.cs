using System.Collections.Generic;
using System.Linq;
using MVCUsingWebAPIWithAngularJS.BR.Models;
using MVCUsingWebAPIWithAngularJS.DataLayer.Models;

namespace MVCUsingWebAPIWithAngularJS.DataLayer
{
    public class Cricketer
    {
        private ConnCricketerContext _dbCricketer;

        public Cricketer()
        {
            //
            _dbCricketer = new ConnCricketerContext();
        }
        /// <summary>
        /// Get Cricketers
        /// </summary>
        /// <returns></returns>
        public List<CricketerViewModel> GetCricketers()
        {
            var cricketer = new List<CricketerViewModel>();
            cricketer = (from x in _dbCricketer.Cricketers
                         select new CricketerViewModel()
                         {
                             Id = x.ID,
                             Name = x.Name,
                             ODI = x.ODI,
                             Test = x.Test,
                             Update=true
                         }
                         ).ToList();
            return cricketer;
        }

        /// <summary>
        /// Delete cricketer
        /// </summary>
        /// <param name="cricketerId"></param>
        public void DeleteCricketer(int Id)
        {
            _dbCricketer.Cricketers.RemoveRange(_dbCricketer.Cricketers.Where(x => x.ID == Id));

            _dbCricketer.SaveChanges();
        }

        /// <summary>
        /// Update cricketer
        /// </summary>
        /// <param name="assesmentViewModel"></param>
        /// <returns></returns>

        public int UpdateCricketer(CricketerViewModel cricketerViewModel)
        {
            MVCUsingWebAPIWithAngularJS.BR.Models.Cricketer cricketer = default(MVCUsingWebAPIWithAngularJS.BR.Models.Cricketer);
            if (cricketerViewModel.Update)
            {
                cricketer = _dbCricketer.Cricketers.Find(cricketerViewModel.Id);
            }
            else
            {
                cricketer = new MVCUsingWebAPIWithAngularJS.BR.Models.Cricketer();
            }
            //add cricketer value
            cricketer.Name = cricketerViewModel.Name;
            cricketer.ODI = cricketerViewModel.ODI;
            cricketer.Test = cricketerViewModel.Test;
            if (!cricketerViewModel.Update)
            {
                _dbCricketer.Cricketers.Add(cricketer);
            }
            _dbCricketer.SaveChanges();

            return cricketer.ID;
        }

        /// <summary>
        /// Detail
        /// </summary>
        /// <param name="cricketerId"></param>
        /// <returns></returns>
        public CricketerDetailViewModel Detail(int cricketerId)
        {
            CricketerDetailViewModel cricketer = new CricketerDetailViewModel();
            cricketer = (from p in _dbCricketer.Cricketer_Details.Where(x => x.Cricketer_ID == cricketerId).DefaultIfEmpty()
                         select new CricketerDetailViewModel
                         {
                             Cricketer_Id = (int)p.Cricketer_ID,
                             Team = p.Team,
                             ODI_Runs = (int)p.ODI_Runs,
                             Test_Runs = (int)p.Test_Runs,
                             Wickets = (int)p.Wickets
                         }).FirstOrDefault();
            return cricketer;
        }


        /// <summary>
        /// ODI Stats
        /// </summary>
        /// <param name="cricketerId"></param>
        /// <returns></returns>
        public CricketerODIStatsViewModel ODIStats(int cricketerId)
        {
            CricketerODIStatsViewModel cricketer = new CricketerODIStatsViewModel();
            cricketer = (from p in _dbCricketer.Cricketer_ODI_Statistics.Where(x => x.Cricketer_ID == cricketerId).DefaultIfEmpty()
                         select new CricketerODIStatsViewModel
                         {
                             Cricketer_Id = (int)p.Cricketer_ID,
                             Name = p.Name,
                             Half_Century = (int)p.Half_Century,
                             Century = (int)p.Century                             
                         }).FirstOrDefault();
            return cricketer;
        }

        /// <summary>
        /// Test Stats
        /// </summary>
        /// <param name="cricketerId"></param>
        /// <returns></returns>
        public CricketerTestStatsViewModel TestStats(int cricketerId)
        {
            CricketerTestStatsViewModel cricketer = new CricketerTestStatsViewModel();
            cricketer = (from p in _dbCricketer.Cricketer_Test_Statistics.Where(x => x.Cricketer_ID == cricketerId).DefaultIfEmpty()
                         select new CricketerTestStatsViewModel
                         {
                             Cricketer_Id = (int)p.Cricketer_ID,
                             Name = p.Name,
                             Half_Century = (int)p.Half_Century,
                             Century = (int)p.Century
                         }).FirstOrDefault();
            return cricketer;
        }
    }
}
