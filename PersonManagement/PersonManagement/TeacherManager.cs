using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement
{
    public class TeacherManager
    {
        private static List<Teacher> teachers;
        public TeacherManager()
        {
            if(teachers == null)
                teachers = new List<Teacher>();
        }
        public OperationResult Add(Teacher teacher)
        {
            var validation = teacher.Validate();
            if (!validation.IsSuccess)
                return validation;
            foreach (var item in teachers)
            {
                if (teacher.Mobile == item.Mobile)
                    return OperationResult.Failed(Messages.DuplicateMobileNumber);
                if (teacher.NationalCode == item.NationalCode)
                    return OperationResult.Failed(Messages.DuplicateNationalCode);
            }
            teachers.Add(teacher);
            return OperationResult.Success(Messages.TeacherCreatedSuccessfully);
        }
        public void Remove(Teacher teacher)
        {
            teachers.Remove(teacher);
        }
        public OperationResult Edit(Teacher teacher)
        {
            var validation = teacher.Validate();
            if (!validation.IsSuccess)
                return validation;
            Teacher teacherToEdit = null;
            foreach (var item in teachers)
            {
                if (item.Mobile == teacher.Mobile)
                {
                    teacherToEdit = item;
                    break;
                }
            }
            foreach (var item in teachers)
            {
                if (item != teacherToEdit && item.NationalCode == teacher.NationalCode)
                    return OperationResult.Failed(Messages.DuplicateNationalCode);
            }
            if (teacherToEdit == null)
                return OperationResult.Failed(Messages.TeacherNotFound);
            teacherToEdit.FirstName = teacher.FirstName;
            teacherToEdit.LastName = teacher.LastName;
            teacherToEdit.NationalCode = teacher.NationalCode;
            teacherToEdit.Gender = teacher.Gender;
            teacherToEdit.Mobile = teacher.Mobile;
            teacherToEdit.Address = teacher.Address;
            teacherToEdit.Field = teacher.Field;
            return OperationResult.Success(Messages.TeacherUpdatedSuccessfully);
        }
        public IReadOnlyList<Teacher> GetAll()
        {
            return teachers;
        }
    }
}