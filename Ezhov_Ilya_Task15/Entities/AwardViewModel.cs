using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AwardViewModel
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public static AwardViewModel GetAwardViewModel(Award award)
        {
            var awardModel = new AwardViewModel();
            awardModel.id = award.id;
            awardModel.Title = award.Title;
            awardModel.Description = award.Description;

            return awardModel;
        }
    }
}
