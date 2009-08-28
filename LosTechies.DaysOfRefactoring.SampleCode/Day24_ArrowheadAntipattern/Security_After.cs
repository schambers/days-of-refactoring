using System.Collections.Generic;
using System.Linq;

namespace LosTechies.DaysOfRefactoring.SampleCode.ArrowheadAntipattern.After
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
			if (user == null || permission == null)
				return false;

			if (exemptions.Contains(permission))
				return true;

			return SecurityChecker.CheckPermission(user, permission);
		}
	}
}
