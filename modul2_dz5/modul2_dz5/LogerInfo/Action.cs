using System;
using System.Collections.Generic;
using System.Text;

namespace modul2_dz5.LogerInfo
{
    public class Action
    {
        private readonly Logger _logger = Logger.Instance;
        public Result FirstMethod()
        {
            _logger.LogEventInfo($"Start method: {nameof(FirstMethod)}");
            return new Result { Status=true};
        }
        public Result SecondMethod()
        {
            _logger.LogEventInfo($"Skipped logic in method: {nameof(SecondMethod)}");
            return new Result { Status = true };
        }
        public Result ThirdMethod()

        {
            return new Result { Status = false, ErrorMessage="I broke a logic!" };
        }
    }
}
