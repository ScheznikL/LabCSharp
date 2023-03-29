using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LR3_SH
{

    public class University
    {
        // static UniversityEqualityComparer UnEqC = new UniversityEqualityComparer();
        private string _name;
        private int _faculty;
        private int _students;
        private List<Lecturer> _lecturer;
        private List<Engineer> _engineers;
        private List<Hall> _halls;
        private List<Auditory> _lectureAuditoriums;
        private List<Lab> _labAuditoriums;
        private Dictionary<string, Workers> _Workerdict;

        public University()
        {
            _name = "";
            _Workerdict = new Dictionary<string, Workers>();
            _lecturer = new List<Lecturer>();
            _engineers = new List<Engineer>();
            _students = 0;
            _halls = new List<Hall>();
            _lectureAuditoriums = new List<Auditory>();
            _labAuditoriums = new List<Lab>();
        }

        public University(string name, int faculty, int students,
             List<Hall> halls, Dictionary<string, Workers> Workerdict)
        {
            _name = name;
            _faculty = faculty;
            _students = students;
            _halls = halls;
            _Workerdict = Workerdict;
        }

        public University(string name, int faculty, int students, List<Lecturer> lecturer,
            List<Engineer> engineers, List<Hall> halls, List<Auditory> lectureAuditoriums,
            List<Lab> labAuditoriums, Dictionary<string, Workers> Workerdict)
        {
            _name = name;
            _faculty = faculty;
            _students = students;
            _lecturer = lecturer;
            _engineers = engineers;
            _halls = halls;
            _lectureAuditoriums = lectureAuditoriums;
            _labAuditoriums = labAuditoriums;
            _Workerdict = Workerdict;
        }

        public string Name
        {
            get => _name;
            set
            {
                int num;
                if (!string.IsNullOrWhiteSpace(value) && !(int.TryParse(value, out num)))
                    _name = value;
                else
                {
                    MessageBox.Show("Value is incorrect!");
                }
            }
        }
        public int this[Type auditoriumType]
        {
            get
            {
                if (auditoriumType == typeof(Auditory))
                    return GetNumberOfLecAuditoriums();
                else
                    return GetNumberOfLabAuditoriums();
            }
        }
        public int Lab
        {
            get => GetNumberOfLabAuditoriums();
        }
        public int Lec
        {
            get => GetNumberOfLecAuditoriums();
        }
        public int Teachers
        {
            get
            { return GetNumberOfTeachersFromWorkers(IsTeach); }
        }
        public int Engineer
        {
            get => GetNumberOfTeachersFromWorkers(IsEngeneer);
        }
        private int GetNumberOfLecAuditoriums()
        {
            return GetNumberOfChosenAuditoriums(IsLec);
        }
        private int GetNumberOfLabAuditoriums()
        {
            return GetNumberOfChosenAuditoriums(IsLab);
        }
        private int GetNumberOfChosenAuditoriums(Func<Hall, bool> isOfChosenTypeDelegate)
        {
            int numberOfChosenAuditoriums = 0;
            foreach (Hall auditorium in _halls)
            {
                if (isOfChosenTypeDelegate(auditorium))
                    numberOfChosenAuditoriums++;
            }
            return numberOfChosenAuditoriums;
        }
        private bool IsLec(Hall auditorium)
        {
            return auditorium is Auditory;
        }
        private bool IsLab(Hall auditorium)
        {
            return auditorium is Lab;
        }
        private bool IsTeach(Workers people)
        {
            return people is Lecturer;
        }
        private bool IsEngeneer(Workers people)
        {
            return people is Engineer;
        }

        private int GetNumberOfTeachersFromWorkers(Func<Workers, bool> isOfChosenTypeDelegate)
        {
            int numberOfLecturer = 0;
            foreach (Workers human in _Workerdict.Values)
            {
                if (isOfChosenTypeDelegate(human))
                    numberOfLecturer++;
            }
            return numberOfLecturer;
        }


        public int Staff => _lecturer.Count + _engineers.Count;
        public int Students
        {
            get => _students;
            set
            {
                if (_students < _lecturer.Count * 10)
                    _students = value;
                else if (_lecturer.Count == 0)
                {
                    _students = value;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(_name))
                        MessageBox.Show($"{_name} is full!");
                    else
                        MessageBox.Show($"The University is full!");
                }
            }
        }
        public int Faculty { get => _faculty; set => _faculty = value; }
        public Dictionary<string, Workers> Workerdict { get => _Workerdict; }

        public void AddLecturer(Lecturer lec) { _lecturer.Add(lec); }
        public void Engineers(Engineer en) { _engineers.Add(en); }
        public void Halls(/*Hall room*/)
        {
//if (room is Lab)
                foreach (var aud in _labAuditoriums)
                    _halls.Add(aud);
//       if(room is Auditory)
                foreach (var aud in _lectureAuditoriums)
                    _halls.Add(aud);
        }
        public List<Hall> GetHall { get => _halls; }
        public List<Lecturer> GetLectr { get => _lecturer; }
        public List<Engineer> GetEn { get => _engineers; }
        public void LectureAuditoriums(Auditory aud)
        {
            aud.ID = _lectureAuditoriums.Count + _labAuditoriums.Count + 1;
            _lectureAuditoriums.Add(aud);
        }
        public void LabAuditoriums(Lab lab)
        {
            lab.ID = _labAuditoriums.Count + _lectureAuditoriums.Count + 1;
            _labAuditoriums.Add(lab);
        }
        public void WorkerAdd()
        {
            foreach (var person in _lecturer)
            {
                if (!_Workerdict.ContainsKey(person.Passport))
                {
                    _Workerdict.Add(person.Passport, person);
                    // ForDisplay.Add(Univer);
                }
                else
                {
                    MessageBox.Show($"lecturer with passport: {person.Passport} alreadyy in the base.");
                }
            }
            foreach (var person in _engineers)
            {
                if (!_Workerdict.ContainsKey(person.Passport))
                {
                    _Workerdict.Add(person.Passport, person);
                }
                else
                {
                    MessageBox.Show($"enineer with passport: {person.Passport}  alreadyy in the base.");
                }
            }
        }

        private Lab ToLabFromLecture(Auditory lectureAuditorium)
        {
            return new Lab(0, 0, lectureAuditorium.Places/*,lectureAuditorium.Engineers*/);
        }
        private Auditory ToLectureFromLab(Lab labAuditorium)
        {
            return new Auditory(labAuditorium.Places, 0, false, false/*,labAuditorium.Engineers*/);
        }
        public bool AuditoriumIsSuitableForLessons(int auditoriumIndex)
        {
            if (_halls[auditoriumIndex] is Lab)
                return _halls[auditoriumIndex] != null && _halls[auditoriumIndex].EngineersCount == 2;
            else
                return _halls[auditoriumIndex].EngineersCount != 0 && _halls[auditoriumIndex].EngineersCount >= 1;
        }
        public int GetPotentialNumberOfSubjects(int teacherIndex)
        {
            var listW = _Workerdict.Values.ToList();
            var lecturers = listW.OfType<Lecturer>().ToList();
            int numOfsybj = lecturers[teacherIndex].SubjNum;
            return 5 - numOfsybj;
        }

        public static void FileWrite()
        {

        }

        public static void FileRead()
        {

        }
    }
}

