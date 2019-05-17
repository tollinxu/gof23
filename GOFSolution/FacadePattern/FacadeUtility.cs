using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class FacadeUtility
    {
        private RollRoomFeeService rollService { get; set; }

        private UpdateRoomStatus updateService { get; set; }

        public FacadeUtility()
        {
            rollService = new RollRoomFeeService();
            updateService = new UpdateRoomStatus();
        }

        public void NightAudit()
        {
            rollService.RollFee();
            updateService.UpdateStatus();
        }
    }
}
