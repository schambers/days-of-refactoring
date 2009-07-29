using System;

namespace LosTechies.DaysOfRefactoring.RemoveDuplication.Before
{
	public class MedicalRecord
	{
		public DateTime DateArchived { get; private set; }
		public bool Archived { get; private set; }

		public void ArchiveRecord()
		{
			Archived = true;
			DateArchived = DateTime.Now;
		}

		public void CloseRecord()
		{
			Archived = true;
			DateArchived = DateTime.Now;
		}
	}
}