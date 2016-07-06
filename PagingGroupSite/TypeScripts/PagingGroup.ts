namespace Homework
{
	export class PagingGroup
	{
		public GroupingFieldValues<T>(testData: T[], fieldName: string, pagingCount: number): number[]
		{
			var result = [];
			testData.forEach((v, i) =>
			{
				var idx = Math.floor(i / pagingCount);
				if (result[idx] == null)
					result[idx] = 0;

				result[idx] += v[fieldName];
			});

			return result;
		}
	}
}