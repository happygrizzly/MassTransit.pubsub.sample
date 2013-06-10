﻿using System;
using MassTransit;
using Messages;

namespace Subscriber.UpdateEmployee
{
	public class UpdateEmployeeConsumer : Consumes<EmployeeUpdatedMessage>.All
	{
		public void Consume(EmployeeUpdatedMessage updatedMessage)
		{
			Console.WriteLine(string.Format("ID: {0}, First Name: {1}, Last Name: {2}", updatedMessage.Id, updatedMessage.FirstName,
			                                updatedMessage.LastName));
		}
	}
}