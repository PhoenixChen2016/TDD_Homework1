using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagingGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace PagingGroup.Tests
{
	[TestClass()]
	public class PagingGroupTests
	{
		private IEnumerable<object> GetTestData() => new[]{
			new {
				Id=1,
				Cost = 1,
				Revence = 11,
				SellPrice = 21
			},
			new {
				Id=2,
				Cost = 2,
				Revence = 12,
				SellPrice = 22
			},
			new {
				Id=3,
				Cost = 3,
				Revence = 13,
				SellPrice = 23
			},
			new {
				Id=4,
				Cost = 4,
				Revence = 14,
				SellPrice = 24
			},
			new {
				Id=5,
				Cost = 5,
				Revence = 15,
				SellPrice = 25
			},
			new {
				Id=6,
				Cost = 6,
				Revence = 16,
				SellPrice = 26
			},
			new {
				Id=7,
				Cost = 7,
				Revence = 17,
				SellPrice = 27
			},
			new {
				Id=8,
				Cost = 8,
				Revence = 18,
				SellPrice = 28
			},
			new {
				Id=9,
				Cost = 9,
				Revence = 19,
				SellPrice = 29
			},
			new {
				Id=10,
				Cost = 10,
				Revence = 20,
				SellPrice = 30
			},
			new {
				Id=11,
				Cost = 11,
				Revence = 21,
				SellPrice = 31
			}
		};

		[TestMethod()]
		public void GroupingFieldValuesTest_輸入欄位名稱Cost_3筆一組會得到結果6_15_24_21()
		{
			// arrange
			var sut = new PagingGroup();

			var testData = GetTestData();
			var fieldName = "Cost";
			var pagingCount = 3;

			// act
			var actual = sut.GroupingFieldValues(testData, fieldName, pagingCount);

			// assert
			var expected = new[] { 6, 15, 24, 21 };

			expected.ToExpectedObject().ShouldEqual(actual);
		}

		[TestMethod()]
		public void GroupingFieldValuesTest_輸入欄位名稱Revenue_4筆一組會得到結果50_66_60()
		{
			// arrange
			var sut = new PagingGroup();

			var testData = GetTestData();
			var fieldName = "Revenue";
			var pagingCount = 4;

			// act
			var actual = sut.GroupingFieldValues(testData, fieldName, pagingCount);

			// assert
			var expected = new[] { 50, 66, 60 };

			expected.ToExpectedObject().ShouldEqual(actual);
		}
	}
}