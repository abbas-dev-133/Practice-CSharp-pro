using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace PersonManagement
{
    public class StudentManager
    {
        private static List<Student> students;
        public StudentManager()
        {
            if (students == null)
                students = new List<Student>();
        }
        public OperationResult<Student> GetByStudentCode(string studentCode)
        {
            foreach (var s in students)
            {
                if (s.StudentCode == studentCode)
                {
                    return  OperationResult<Student>.Success(Messages.StudentFoundSuccessfully, s);
                }
            }
            return  OperationResult<Student>.Failed(Messages.StudentNotFound);
        }
        public OperationResult Add(Student student)
        {
            var validation = student.Validate();
            if (!validation.IsSuccess)
                return validation;
            foreach (var item in students)
            {
                if (student.StudentCode == item.StudentCode)
                    return OperationResult.Failed(Messages.DuplicateStudentCode);
                if (student.NationalCode == item.NationalCode)
                    return OperationResult.Failed(Messages.DuplicateNationalCode);
            }
            students.Add(student);
            return OperationResult.Success(Messages.StudentCreatedSuccessfully);
        }
        public void Remove(Student student)
        {
            students.Remove(student);
        }
        public OperationResult Edit(Student student)
        {
            var validation = student.Validate();
            if (!validation.IsSuccess)
                return validation;
            Student studentToEdit = null;
            foreach (var item in students)
            {
                if (item.StudentCode == student.StudentCode)
                {
                    studentToEdit = item;
                    break;
                }
            }
            foreach (var item in students)
            {
                if (item != studentToEdit && item.NationalCode == student.NationalCode)
                    return OperationResult.Failed(Messages.DuplicateNationalCode);
            }
            if (studentToEdit == null)
                return OperationResult.Failed(Messages.StudentNotFound);
            studentToEdit.FirstName = student.FirstName;
            studentToEdit.LastName = student.LastName;
            studentToEdit.NationalCode = student.NationalCode;
            studentToEdit.Gender = student.Gender;
            studentToEdit.Grade = student.Grade;
            return OperationResult.Success(Messages.StudentUpdatedSuccessfully);
        }
        public IReadOnlyList<Student> GetAll()
        {
            return students;
        }
    }
}
