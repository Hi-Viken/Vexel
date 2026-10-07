/*******************************************************************************
 * Copyright © 2026 Viken 版权所有
 * Author: Viken
 * Description: Vexel快速开发平台
 * Website：
*********************************************************************************/

using System;

namespace Vexel.Domain
{
	public interface ICreationAudited
	{
		string F_Id { get; set; }
		string F_CreatorUserId { get; set; }
		DateTime? F_CreatorTime { get; set; }
	}
}