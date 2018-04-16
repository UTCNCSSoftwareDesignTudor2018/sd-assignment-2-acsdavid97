using System.Globalization;
using iTextSharp.text.pdf;
using StudentManagement.Business.Entity;

namespace StudentManagement.Reporting
{
    class StudentPdfReportBody : IStudentReportBody
    {
        private readonly StudentPdfReportBuilder _pdfBuilder;
        private readonly PdfPTable _table;

        private const int NrColumns = 3;

        public StudentPdfReportBody(StudentPdfReportBuilder pdfBuilder)
        {
            _pdfBuilder = pdfBuilder;
            _table = new PdfPTable(NrColumns);
            _table.AddCell("Course name");
            _table.AddCell("Date graded");
            _table.AddCell("Mark");

        }

        public IStudentReportBody AddGrade(Grade grade)
        {
            _table.AddCell(grade.Course.ToString());
            _table.AddCell(grade.DateGraded.ToString(CultureInfo.CurrentCulture));
            _table.AddCell(grade.Mark.ToString());
            return this;
        }

        public IStudentReportBuilder CloseBody()
        {
            _pdfBuilder.PdfDocument.Add(_table);
            return _pdfBuilder;
        }
    }
}