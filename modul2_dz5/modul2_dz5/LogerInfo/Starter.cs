using System;
using System.Collections.Generic;
using System.Text;

namespace modul2_dz5.LogerInfo
{
    public class Starter
    {
        const int minRandom = 1;
        const int maxRandom = 4;
        private const string LoggerFilePath = "log.txt";
        private readonly Logger _logger;
        private readonly Action _action;
        private readonly FileService _fileService;

        public Starter()
        {
            _logger = Logger.Instance;
            _action = new Action();
            _fileService = new FileService();
        }
        public void Run()
        {
            var random = new Random();

            for(var i=100; i<100;i++)
            {
                var result = new Random();
                var randomAction = random.Next(minRandom, maxRandom);

                switch (randomAction)
                {
                    case 1:
                        _ = _action.FirstMethod();
                        break;
                    case 2:
                        _ = _action.SecondMethod();
                        break;
                    case 3:
                        _ = _action.ThirdMethod();
                        break;
                }

                if (!result.Status)
                {
                    _logger.LogEventError($"Action failed by a reason: {result.ErrorMessage}");
                }
            }
            _fileService.Write(LoggerFilePath, _logger.Logs);
        }
    }
}
