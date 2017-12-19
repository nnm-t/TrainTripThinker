using System.Collections;
using System.Printing;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Xps;

using DotNetKit.Windows.Documents;

namespace TrainTripThinker.Model.Printing
{
    public class Printer : IPrinter
    {
        private readonly PrintQueue printQueue;

        public Printer(PrintQueue printQueue)
        {
            this.printQueue = printQueue;
        }

        public string Name => printQueue.Name;

        public void Print(IEnumerable pages, Size pageSize)
        {
            bool isLandScape = pageSize.Width > pageSize.Height;
            Size paperSize = isLandScape ? pageSize.Rotate90() : pageSize;

            PrintTicket ticket = printQueue.DefaultPrintTicket;
            ticket.PageMediaSize = paperSize.ToPageMediaSize();
            ticket.PageOrientation = PageOrientation.Portrait;

            // FixedDocumentを生成
            FixedDocument document = new FixedDocumentCreator().FromDataContexts(pages, pageSize);

            // 印刷
            XpsDocumentWriter writer = PrintQueue.CreateXpsDocumentWriter(printQueue);
            writer.Write(document);
        }
    }
}