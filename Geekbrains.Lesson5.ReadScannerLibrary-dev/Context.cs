using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadScannerLibrary
{
    class Context
    {
        /// <summary>
        /// 
        /// </summary>
        private IStrategy _strategy;

        public Context()
        { }
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void RealizeBusinessLogic(DataModel data)
        {
            var result = this._strategy.DoAlgorithm(data);
        }

    }
}
