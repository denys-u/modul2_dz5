namespace Modul2_dz5.LogerInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Action
    {
        private readonly Logger _logger = Logger.Instance;

        public Result FirstMethod()
        {
            this._logger.LogEventInfo($"Start method: {nameof(this.FirstMethod)}");
            return new Result { Status = true };
        }

        public Result SecondMethod()
        {
            this._logger.LogEventInfo($"Skipped logic in method: {nameof(this.SecondMethod)}");
            return new Result { Status = true };
        }

        public Result ThirdMethod()
        {
            return new Result { Status = false, ErrorMessage = "I broke a logic!" };
        }
    }
}
