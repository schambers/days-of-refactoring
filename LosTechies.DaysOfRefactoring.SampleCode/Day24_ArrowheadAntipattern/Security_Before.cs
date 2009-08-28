using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LosTechies.DaysOfRefactoring.SampleCode.ArrowheadAntipattern.Before
{
	public class Security
	{
		public ISecurityChecker SecurityChecker { get; set; }

		public Security(ISecurityChecker securityChecker)
		{
			SecurityChecker = securityChecker;
		}

		public bool HasAccess(User user, Permission permission, IEnumerable<Permission> exemptions)
		{
			bool hasPermission = false;

			if (user != null)
			{
				if (permission != null)
				{
					if (exemptions.Count() == 0)
					{
						if (SecurityChecker.CheckPermission(user, permission) || exemptions.Contains(permission))
						{
							hasPermission = true;
						}
					}
				}
			}

			return hasPermission;
		}
	}
}
