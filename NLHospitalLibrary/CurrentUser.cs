using System;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class CurrentUser
	{
		private string user;
		private string userPosition;

		public string UserName
		{
			get
			{
				return user;
			}
			set
			{
				user = value;
			}
		}

		public string UserPosition
		{
			get
			{
				return userPosition;
			}
			set
			{
				userPosition = value;
			}
		}

		public CurrentUser()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public CurrentUser(string userID, string Position)
		{
			UserName = userID;
			userPosition = Position;

		}
	}
}
