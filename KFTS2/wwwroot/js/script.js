window.onload = function () {
	var giderler = new CanvasJS.Chart("giderler",
		{
			animationEnabled: true,
			theme: "light2", // "light1", "light2", "dark1", "dark2"
			title: {
				text: "Son 1 Aylık Gider"
			},
			axisY: {
				title: "Gider Miktarı (₺)",
				suffix: "₺"
			},
			axisX: {
				title: ""
			},
			data: [{
				type: "column",
				yValueFormatString: "#,##0",
				dataPoints: [
					{ label: "Kira", y: 7.1 },
					{ label: "Ev Masrafları", y: 6.70 },
					{ label: "Faturalar", y: 5.00 },
					{ label: "Eğlence", y: 2.50 },
					{ label: "Yatırım", y: 2.30 },
					{ label: "Kredi Kartları", y: 1.80 },
					{ label: "Ekstra Giderler", y: 1.80 },
					{ label: "Toplam", y: 1.80 }
				]
			}]
		});
	giderler.render();
	var gelirler = new CanvasJS.Chart("gelirler",
		{
			animationEnabled: true,
			theme: "light2", // "light1", "light2", "dark1", "dark2"
			title: {
				text: "Son 1 Aylık Gelir"
			},
			axisY: {
				title: "Gelir Miktarları (₺)",
				suffix: "₺"
			},
			axisX: {
				title: ""
			},
			data: [{
				type: "column",
				yValueFormatString: "#,##0",
				dataPoints: [
					{ label: "Maaş", y: 7.1 },
					{ label: "Kira", y: 6.70 },
					{ label: "Borsa", y: 5.00 },
					{ label: "Kripto", y: 2.50 },
					{ label: "Toplam", y: 1.80 }
				]
			}]
		});
	gelirler.render();


	//-------------------------------------------
	//         SÜTUN GRAFİKLERİ
	//-------------------------------------------


	var gelir1yil = new CanvasJS.Chart("gelir1yil", {
		animationEnabled: true,
		theme: "light2", // "light1", "light2", "dark1", "dark2"
		title: {
			text: "Son 1 Yıllık Gelir"
		},
		axisY: {
			title: "Gelir Miktarları (₺)",
			suffix: "₺"
		},
		axisX: {
			title: ""
		},
		data: [{
			type: "column",
			yValueFormatString: "#,##0",
			dataPoints: [
				{ label: "Maaş", y: 7.1 },
				{ label: "Kira", y: 6.70 },
				{ label: "Borsa", y: 5.00 },
				{ label: "Kripto", y: 2.50 },
				{ label: "Toplam", y: 1.80 }
			]
		}]
	});
	gelir1yil.render();

	var gelir6ay = new CanvasJS.Chart("gelir6ay", {
		animationEnabled: true,
		theme: "light2", // "light1", "light2", "dark1", "dark2"
		title: {
			text: "Son 6 Aylık Gelirler"
		},
		axisY: {
			title: "Gelir Miktarı (₺)",
			suffix: "₺"
		},
		axisX: {
			title: ""
		},
		data: [{
			type: "column",
			yValueFormatString: "#,##0",
			dataPoints: [
				{ label: "Maaş", y: 7.1 },
				{ label: "Kira", y: 6.70 },
				{ label: "Borsa", y: 5.00 },
				{ label: "Kripto", y: 2.50 },
				{ label: "Toplam", y: 1.80 }

			]
		}]
	});
	gelir6ay.render();

	var gider1yil = new CanvasJS.Chart("gider1yil", {
		animationEnabled: true,
		theme: "light2", // "light1", "light2", "dark1", "dark2"
		title: {
			text: "Son 1 Yıllık Giderler"
		},
		axisY: {
			title: "Gider Miktarı (₺)",
			suffix: "₺"
		},
		axisX: {
			title: ""
		},
		data: [{
			type: "column",
			yValueFormatString: "#,##0",
			dataPoints: [
				{ label: "Kira", y: 7.1 },
				{ label: "Ev Masrafları", y: 6.70 },
				{ label: "Faturalar", y: 5.00 },
				{ label: "Eğlence", y: 2.50 },
				{ label: "Yatırım", y: 2.30 },
				{ label: "Kredi Kartları", y: 1.80 },
				{ label: "Ekstra Giderler", y: 1.80 },
				{ label: "Toplam", y: 1.80 }
			]
		}]
	});
	gider1yil.render();

	var gider6ay = new CanvasJS.Chart("gider6ay", {
		animationEnabled: true,
		theme: "light2", // "light1", "light2", "dark1", "dark2"
		title: {
			text: "Son 6 Aylık Giderler"
		},
		axisY: {
			title: "Gider Miktarı (₺)",
			suffix: "₺"
		},
		axisX: {
			title: ""
		},
		data: [{
			type: "column",
			yValueFormatString: "#,##0",
			dataPoints: [
				{ label: "Kira", y: 7.1 },
				{ label: "Ev Masrafları", y: 6.70 },
				{ label: "Faturalar", y: 5.00 },
				{ label: "Eğlence", y: 2.50 },
				{ label: "Yatırım", y: 2.30 },
				{ label: "Kredi Kartları", y: 1.80 },
				{ label: "Ekstra Giderler", y: 1.80 },
				{ label: "Toplam", y: 1.80 }
			]
		}]
	});
	gider6ay.render();
}