using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;

using DotNetKit.Misc.Disposables;

using Prism.Mvvm;

namespace TrainTripThinker.Model.Printing
{
    public class PrinterSelector<TPrinter> : BindableBase, IDisposable
        where TPrinter : IPrinter
    {
        private readonly IDisposable disposable;

        private TPrinter selectedPrinter;

        private PrinterSelector(IEnumerable<TPrinter> printers, TPrinter defaultPrinter, IDisposable disposable)
        {
            this.disposable = disposable;

            Printers = printers;
            SelectedPrinter = defaultPrinter;
        }

        public IEnumerable<TPrinter> Printers { get; }

        public TPrinter SelectedPrinter
        {
            get => selectedPrinter;
            set => SetProperty(ref selectedPrinter, value);
        }

        public static PrinterSelector<T> FromLocalServer<T>(Func<PrintQueue, T> printerFromPrintQueue)
            where T : class, IPrinter
        {
            var server = new LocalPrintServer();
            PrintQueueCollection printQueueCollection = server.GetPrintQueues();

            var disposable = new AnonymousDisposable(() =>
                   {
                       server.Dispose();
                       printQueueCollection.Dispose();
                   });

            IEnumerable<T> printers = printQueueCollection.Select(printerFromPrintQueue);

            try
            {
                int defaultIndex = FindDefaultPrinter(printQueueCollection, server.DefaultPrintQueue);

                T defaultPrinter = printers.Skip(defaultIndex).First();

                return new PrinterSelector<T>(printers, defaultPrinter, disposable);
            }
            catch (ArgumentNullException)
            {
                // DefaultPrintQueueがnull
                return new PrinterSelector<T>(printers, null, disposable);
            }
            catch (InvalidOperationException)
            {
                // DefaultPrintQueueを持ったプリンタが見つからない
                return new PrinterSelector<T>(printers, null, disposable);
            }
        }

        public void Dispose()
        {
            disposable.Dispose();
        }

        private static int FindDefaultPrinter(IEnumerable<PrintQueue> queues, PrintQueue defaultPrintQueue)
        {
            if (defaultPrintQueue == null)
            {
                throw new ArgumentNullException(nameof(defaultPrintQueue));
            }

            var defaultQueue = queues.Select((queue, index) => new { queue, index })
                .First(x => x.queue.Name == defaultPrintQueue.Name);

            return defaultQueue.index;
        }
    }
}