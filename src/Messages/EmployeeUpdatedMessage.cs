﻿using System;

namespace Messages
{
	public class EmployeeUpdatedMessage
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}