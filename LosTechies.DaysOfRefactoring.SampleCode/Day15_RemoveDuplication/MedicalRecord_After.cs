using System;

namespace LosTechies.DaysOfRefactoring.RemoveDuplication.After
{
	public class MedicalRecord
	{
		public DateTime DateArchived { get; private set; }
		public bool Archived { get; private set; }

		public void ArchiveRecord()
		{
			SwitchToArchived();
		}

		public void CloseRecord()
		{
			SwitchToArchived();
		}

		private void SwitchToArchived()
		{
			Archived = true;
			DateArchived = DateTime.Now;
		}
	}
}