using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using StudentManagement.Business.Entity;

namespace StudentManagement.Reporting
{
    public class StudentPdfReportBuilder : IStudentReportBuilder
    {
        internal Document PdfDocument { get; private set; }
        private PdfWriter _pdfWriter;
        private readonly string _location;

        public StudentPdfReportBuilder(string location)
        {
            _location = location;
        }

        public IStudentReportBody CreateReportFor(Student student)
        {
            PdfDocument = new Document();

            _pdfWriter = PdfWriter.GetInstance(PdfDocument, new FileStream(_location, FileMode.Create));

            PdfDocument.Open();
            PdfDocument.NewPage();
            PdfDocument.Add(new Paragraph(student.Name));
            return new StudentPdfReportBody(this);
        }

        public void Dispose()
        {
            PdfDocument.Close();
            _pdfWriter.Dispose();
            PdfDocument.Dispose();
        }
    }
}
