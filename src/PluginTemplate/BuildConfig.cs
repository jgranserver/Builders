using System;
using System.Collections.Generic;

namespace BuildMaster
{
	// Token: 0x02000002 RID: 2
	public class BuildConfig
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public bool UnlockAll { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00000261
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		public Dictionary<int, int> Range { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00000272
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000207A File Offset: 0x0000027A
		public List<int> BanItem { get; set; }

		// Token: 0x06000007 RID: 7 RVA: 0x00002083 File Offset: 0x00000283
		public BuildConfig()
		{
			this.UnlockAll = true;
			this.Range = new Dictionary<int, int>();
			this.BanItem = new List<int>();
		}
	}
}
