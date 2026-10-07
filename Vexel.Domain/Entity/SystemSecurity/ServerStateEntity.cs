//-----------------------------------------------------------------------
// <copyright file=" ServerState.cs" company="Vexel">
// * Copyright (C) 2026 Viken  All Rights Reserved
// * version : 1.0
// * author  : Viken
// * FileName: ServerState.cs
// * history : Created by T4 2026-10-07 11:54:49
// </copyright>
//-----------------------------------------------------------------------
using SqlSugar;
using System;

namespace Vexel.Domain.SystemSecurity
{
	/// <summary>
	/// ServerState Entity Model
	/// </summary>
	[SugarTable("sys_serverstate")]
	public class ServerStateEntity : IEntity<ServerStateEntity>
	{
		/// <summary>
		/// Ö÷¼üId
		/// </summary>
		[SugarColumn(ColumnName = "F_Id", IsPrimaryKey = true, ColumnDescription = "Ö÷¼üId")]
		public string F_Id { get; set; }

		/// <summary>
		/// ÍøÕ¾Õ¾µã
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnName = "F_WebSite", ColumnDataType = "nvarchar(200)", ColumnDescription = "ÍøÕ¾Õ¾µã")]
		public string F_WebSite { get; set; }

		/// <summary>
		/// ARM
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnName = "F_ARM", ColumnDataType = "nvarchar(50)", ColumnDescription = "ARM")]
		public string F_ARM { get; set; }

		/// <summary>
		/// CPU
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnName = "F_CPU", ColumnDataType = "nvarchar(50)", ColumnDescription = "CPU")]
		public string F_CPU { get; set; }

		/// <summary>
		/// IIS
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnName = "F_IIS", ColumnDataType = "nvarchar(50)", ColumnDescription = "IIS")]
		public string F_IIS { get; set; }

		/// <summary>
		/// ÈÕÆÚ
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnDescription = "ÈÕÆÚ")]
		public DateTime F_Date { get; set; }

		/// <summary>
		/// ´ÎÊý
		/// </summary>
		[SugarColumn(IsNullable = true, ColumnDescription = "´ÎÊý")]
		public int F_Cout { get; set; }
	}
}