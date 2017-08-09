using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterMotivationCalc {
	class Employee {
		private string shortName;
		public string ShortName {
			get {
				return shortName;
			} set {
				shortName = TrimWhitespacesFromString(value);
			}
		}

		private string fullName;
		public string FullName {
			get {
				return fullName;
			} set {
				fullName = TrimWhitespacesFromString(value);
			}
		}

		private string position;
		public string Position {
			get {
				return position;
			} set {
				position = TrimWhitespacesFromString(value);
			}
		}

		private string pfr;
		public string Pfr {
			get {
				return pfr;
			} set {
				pfr = TrimWhitespacesFromString(value);
			}
		}

		private string rate;
		public string Rate {
			get {
				return rate;
			} set {
				rate = TrimWhitespacesFromString(value);
			}
		}

		private float salary;
		public float Salary {
			get {
				return salary;
			}
		}

		public void SetSalary(string str) {
			salary = ParseStringToFloat(str);
		}

		private float totalHoursPlan;
		public float TotalHoursPlan {
			get {
				return totalHoursPlan;
			}
		}

		public void SetTotalHours(string str) {
			totalHoursPlan = ParseStringToFloat(str);
		}

		private float totalHoursFact;
		public float TotalHoursFact {
			get {
				return totalHoursFact;
			}
		}

		public void AddTotalHoursFact(string str) {
			totalHoursFact += ParseStringToFloat(str);
		}

		private float qualityAverageScore;
		public float QualityAverageScore {
			get {
				return qualityAverageScore;
			}
		}

		public void SetQualityAverageScore (string str) {
			qualityAverageScore = ParseStringToFloat(str);
		}

		private TimeSpan worktimeTotalCallsTime;
		public TimeSpan WorktimeTotalCallsTime {
			get {
				return worktimeTotalCallsTime;
			}
		}

		public void SetWorktimeTotalCallsTime(string str) {
			worktimeTotalCallsTime = ParseStringToTimeSpan(str);
		}

		private TimeSpan worktimeRemainingTime;
		public TimeSpan WorktimeRemainingTime {
			get {
				return worktimeRemainingTime;
			}
		}

		public void SetWorktimeRemainingTime(string str) {
			worktimeRemainingTime = ParseStringToTimeSpan(str);
		}

		private TimeSpan worktimePauseTime;
		public TimeSpan WorktimePauseTime {
			get {
				return worktimePauseTime;
			}
		}

		public void SetWorktimePauseTime(string str) {
			worktimePauseTime = ParseStringToTimeSpan(str);
		}

		public bool HasNightHours { get; set; }

		private List<int> daysWithMorningHours = new List<int>();
		public void AddDayToMorningHours(int day) {
			daysWithMorningHours.Add(day);
		}

		private List<int> daysWithNightHours = new List<int>();
		public void AddDayToNightHours(int day) {
			daysWithNightHours.Add(day);
		}

		private int acceptedAndMissedTotalCalls;
		public int AcceptedAndMissedTotalCalls {
			get {
				return acceptedAndMissedTotalCalls;
			}
		}
		public void AddAcceptedAndMissedTotalCalls(string str) {
			acceptedAndMissedTotalCalls += (int)ParseStringToFloat(str);
		}

		private int acceptedAndMissedMissedCalls;
		public int AcceptedAndMissedMissedCalls {
			get {
				return acceptedAndMissedMissedCalls;
			}
		}
		public void AddAcceptedAndMissedMissedCalls(string str) {
			acceptedAndMissedMissedCalls += (int)ParseStringToFloat(str);
		}

		private int acceptedAndMissedWrongCalls;
		public int AcceptedAndMissedWrongCalls {
			get {
				return acceptedAndMissedWrongCalls;
			}
		}
		public void AddAcceptedAndMissedWrongCalls(string str) {
			acceptedAndMissedWrongCalls += (int)ParseStringToFloat(str);
		}






		public Employee() {

		}


		public float GetAcceptedAndMissedCoefficient() {
			float missedCallsPercent = GetAcceptedAndMissedResult();
			float standardValue = Properties.Settings.Default.AcceptedAndMissedCallsStandardValue;
			float desiredValue = Properties.Settings.Default.AcceptedAndMissedCallsDesiredValue;
			float maxCoefficient = Properties.Settings.Default.AcceptedAndMissedCallsMaxCoefficient;

			if (missedCallsPercent <= desiredValue) {
				return maxCoefficient;
			} else if (missedCallsPercent >= standardValue) {
				return 0;
			} else {
				return maxCoefficient * (standardValue - missedCallsPercent) / (standardValue - desiredValue);
			}
		}

		public float GetAcceptedAndMissedResult() {
			if (AcceptedAndMissedTotalCalls == 0)
				return 0;

			return ((float)AcceptedAndMissedMissedCalls - (float)AcceptedAndMissedWrongCalls) / (float)AcceptedAndMissedTotalCalls;
		}

		public bool IsDayInNightHours(int day) {
			return daysWithNightHours.Contains(day);
		}

		public bool IsDayInMorningHours(int day) {
			return daysWithMorningHours.Contains(day);
		}

		public float GetQualityResult() {
			return QualityAverageScore / 100.0f;
		}

		public float GetQualityCoefficient() {
			float qualityResult = GetQualityResult();
			float standardValue = Properties.Settings.Default.OperatorsQualityStandardValue;
			float desiredValue = Properties.Settings.Default.OperatorsQualityDesiredValue;
			float maxCoefficient = Properties.Settings.Default.OperatorsQualityMaxCoefficient;

			return CalculateCoefficient(qualityResult, standardValue, desiredValue, maxCoefficient);
		}

		public float GetWorktimeCoefficient() {
			float congestion = GetWorktimeCongestion();
			float standardValue = Properties.Settings.Default.OperatorsWorktimeStandardValue;
			float desiredValue = Properties.Settings.Default.OperatorsWorktimeDesiredValue;
			float maxCoefficient = Properties.Settings.Default.OperatorsWorktimeMaxCoefficient;

			return CalculateCoefficient(congestion, standardValue, desiredValue, maxCoefficient);
		}

		private float CalculateCoefficient(float value, float standardValue, float desiredValue, float maxCoefficient) {
			if (value >= desiredValue) {
				return maxCoefficient;
			} else if (value <= standardValue) {
				return 0.0f;
			} else {
				return maxCoefficient * (value - standardValue) / (desiredValue - standardValue);
			}
		}

		public float GetWorktimeCongestion() {
			float workTime = (float)(WorktimeTotalCallsTime.TotalSeconds + WorktimePauseTime.TotalSeconds);
			float totalTime = (float)(workTime + WorktimeRemainingTime.TotalSeconds);

			return (totalTime != 0) ? workTime / totalTime : 0;
		}

		private TimeSpan ParseStringToTimeSpan(String str) {
			TimeSpan timeSpan = new TimeSpan();
			TimeSpan.TryParse(str, out timeSpan);
			return timeSpan;
		}
		
		public float GetSpentTime() {
			return TotalHoursPlan != 0 ? TotalHoursFact / TotalHoursPlan : 0;
		}
		
		public float ParseStringToFloat(string str) {
			float value = 0.0f;
			float.TryParse(str, out value);
			return value;
		}
		
		public static string TrimWhitespacesFromString(string str) {
			str = str.Trim().TrimStart().TrimEnd();
			return string.IsNullOrWhiteSpace(str) ? "" : str;
		}

		public override string ToString() {
			return shortName + Environment.NewLine +
				"\tfullName: \t\t\t" + fullName + Environment.NewLine +
				"\tposition: \t\t\t" + position + Environment.NewLine +
				"\tshift: \t\t\t" + rate + Environment.NewLine +
				"\tsalary: \t\t\t" + Salary + Environment.NewLine +
				"\ttotalHoursPlan: \t\t" + TotalHoursPlan + Environment.NewLine +
				"\ttotalHoursFact: \t\t" + TotalHoursFact + Environment.NewLine +
				"\thasNightHours: \t\t" + HasNightHours + Environment.NewLine +
				"\tdaysWithMorningHours: \t" + string.Join(", ", daysWithMorningHours) + Environment.NewLine +
				"\tdaysWithNightHours: \t" + string.Join(", ", daysWithNightHours) + Environment.NewLine +
				"\tqualityAverageScore: \t" + QualityAverageScore + Environment.NewLine +
				"\tworktimeTotalCallsTime: \t" + WorktimeTotalCallsTime + Environment.NewLine +
				"\tworktimeRemainingTime: \t" + WorktimeRemainingTime + Environment.NewLine +
				"\tworktimePauseTime: \t" + WorktimePauseTime + Environment.NewLine +
				"\tacceptedAndMissedTotalCalls: \t" + AcceptedAndMissedTotalCalls + Environment.NewLine +
				"\tacceptedAndMissedMissedCalls: \t" + AcceptedAndMissedMissedCalls + Environment.NewLine +
				"\tacceptedAndMissedWrongCalls: \t" + AcceptedAndMissedWrongCalls;
		}
	}
}
