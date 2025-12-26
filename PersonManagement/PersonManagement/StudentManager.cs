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
            if(students == null)
                students = new List<Student>();
        }
        public Student Get (string studentCode)
        {
            Student foundStudent = null;
            foreach (var s in students)
            {
                if (s.StudentCode == studentCode)
                {
                    foundStudent = s;
                    break;
                } 
            }
            return foundStudent;
        }
        public OperationResult Add(Student student)
        {
            var validation = student.Validate();
            if (!validation.IsSuccess)
                return validation;
            foreach (var item in students)
            {
                if (student.StudentCode == item.StudentCode)
                    return OperationResult.Failed("کد دانشجویی تکراری است");
                if (student.NationalCode == item.NationalCode)
                    return OperationResult.Failed(" کد ملی تکراری است");
            }
            students.Add(student);
            return OperationResult.Success("دانشجو با موفقیت ثبت شد");
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
                if(item.StudentCode== student.StudentCode)
                {
                    studentToEdit = item;
                    break;
                }
            }
            foreach (var item in students)
            {
                if (item != studentToEdit && item.NationalCode== student.NationalCode)
                    return OperationResult.Failed(" کد ملی تکراری است");
            }
            if (studentToEdit == null)
                return OperationResult.Failed("دانشجو مورد نظر پیدا نشد");
            studentToEdit.FirstName = student.FirstName;    
            studentToEdit.LastName = student.LastName;
            studentToEdit.NationalCode = student.NationalCode;
            studentToEdit.Gender = student.Gender;
            studentToEdit.Grade = student.Grade;
            return OperationResult.Success("دانشجو با موفقیت ویرایش شد");
        }
        public IReadOnlyList<Student> GetAll()
        {
            return students;
        }
    }
}
