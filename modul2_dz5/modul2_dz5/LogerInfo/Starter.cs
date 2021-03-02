namespace Modul2_dz5.LogerInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Modul2_dz5.LogerInfo;

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
            this._logger = Logger.Instance;
            this._action = new Action();
            this._fileService = new FileService();
        }

        public void Run()
        {
            var random = new Random();

            for (var i = 100; i < 100; i++)
            {
                var result = new Random();
                var randomAction = random.Next(minRandom, maxRandom);

                switch (randomAction)
                {
                    case 1:
                        _ = this._action.FirstMethod();
                        break;
                    case 2:
                        _ = this._action.SecondMethod();
                        break;
                    case 3:
                        _ = this._action.ThirdMethod();
                        break;
                }

                if (!result.Status)
                {
                    this._logger.LogEventError($"Action failed by a reason: {result.ErrorMessage}");
                }
            }

            this._fileService.Write(LoggerFilePath, this._logger.Logs);
        }
    }
}
