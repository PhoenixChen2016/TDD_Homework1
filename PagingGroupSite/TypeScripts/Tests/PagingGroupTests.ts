describe("PagingGroup", () =>
{
	var orders: {
		Id: number,
		Cost: number,
		Revence: number,
		SellPrice: number
	}[];

	beforeEach(() =>
	{
		orders = [
			{
				Id: 1,
				Cost: 1,
				Revence: 11,
				SellPrice: 21
			},
			{
				Id: 2,
				Cost: 2,
				Revence: 12,
				SellPrice: 22
			},
			{
				Id: 3,
				Cost: 3,
				Revence: 13,
				SellPrice: 23
			},
			{
				Id: 4,
				Cost: 4,
				Revence: 14,
				SellPrice: 24
			},
			{
				Id: 5,
				Cost: 5,
				Revence: 15,
				SellPrice: 25
			},
			{
				Id:6,
				Cost: 6,
				Revence: 16,
				SellPrice: 26
			},
			{
				Id: 7,
				Cost: 7,
				Revence: 17,
				SellPrice: 27
			},
			{
				Id: 8,
				Cost: 8,
				Revence: 18,
				SellPrice: 28
			},
			{
				Id: 9,
				Cost: 9,
				Revence: 19,
				SellPrice: 29
			},
			{
				Id: 10,
				Cost: 10,
				Revence: 20,
				SellPrice: 30
			},
			{
				Id: 11,
				Cost: 11,
				Revence: 21,
				SellPrice: 31
			}
		];
	});

	it("輸入欄位名稱Cost_3筆一組會得到結果6_15_24_21", () =>
	{
		// arrange
		var sut = new Homework.PagingGroup();

		var testData = orders;
		var fieldName = "Cost";
		var pagingCount = 3;

		// act
		var actual = sut.GroupingFieldValues(testData, fieldName, pagingCount);

		// assert
		var expected = [6, 15, 24, 21];

		expect(expected).toEqual(actual);
	});

	it("輸入欄位名稱Revenue_4筆一組會得到結果50_66_60", () =>
	{
		// arrange
		var sut = new Homework.PagingGroup();

		var testData = orders;
		var fieldName = "Revence";
		var pagingCount = 3;

		// act
		var actual = sut.GroupingFieldValues(testData, fieldName, pagingCount);

		// assert
		var expected = [50, 66, 60];

		expect(expected).toEqual(actual);
	});
});