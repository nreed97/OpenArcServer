using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ArcEngine;
using ArcInterfaces.Spots;
using ZedGraph;

namespace ArcServer.ArcForms;

public class DxSpotRateGraph : Form
{
	private ArCluster _arc;

	private List<DxSpotRate> _list;

	private IContainer components;

	private ZedGraphControl zedGraphControl1;

	public DxSpotRateGraph(ArCluster arc)
	{
		InitializeComponent();
		_arc = arc;
		_list = _arc.GetDxSpotRate();
	}

	private void DxSpotRateGraph_Load(object sender, EventArgs e)
	{
		CreateChart(zedGraphControl1);
	}

	public void CreateChart(ZedGraphControl zgc)
	{
		GraphPane graphPane = zgc.GraphPane;
		graphPane.Title.Text = "DX Spots";
		graphPane.XAxis.Title.Text = "Minutes";
		graphPane.YAxis.Title.Text = "Spots per Minute";
		double[] array = new double[60];
		for (int i = 0; i < 60; i++)
		{
			array[i] = -60 + i;
		}
		graphPane.Chart.Fill = new Fill(Color.FromArgb(255, 255, 245), Color.FromArgb(255, 255, 190), 90f);
		int num = 0;
		foreach (DxSpotRate item in _list)
		{
			LineItem lineItem = graphPane.AddCurve(item.Call, array, item.DxRate, GetColorByIndex(num));
			lineItem.Symbol.Fill = new Fill(Color.White);
			num++;
		}
		graphPane.XAxis.Scale.Min = -60.0;
		graphPane.XAxis.Scale.Max = 0.0;
		graphPane.YAxis.MajorGrid.IsVisible = true;
		graphPane.YAxis.MinorGrid.IsVisible = true;
		zgc.AxisChange();
	}

	private Color GetColorByIndex(int index)
	{
		return index switch
		{
			0 => Color.Red, 
			1 => Color.Blue, 
			3 => Color.Green, 
			4 => Color.Magenta, 
			5 => Color.Orange, 
			6 => Color.OliveDrab, 
			7 => Color.Tan, 
			8 => Color.SkyBlue, 
			9 => Color.Lime, 
			10 => Color.Turquoise, 
			11 => Color.Pink, 
			_ => Color.DarkGreen, 
		};
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
		base.SuspendLayout();
		this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
		this.zedGraphControl1.Name = "zedGraphControl1";
		this.zedGraphControl1.ScrollGrace = 0.0;
		this.zedGraphControl1.ScrollMaxX = 0.0;
		this.zedGraphControl1.ScrollMaxY = 0.0;
		this.zedGraphControl1.ScrollMaxY2 = 0.0;
		this.zedGraphControl1.ScrollMinX = 0.0;
		this.zedGraphControl1.ScrollMinY = 0.0;
		this.zedGraphControl1.ScrollMinY2 = 0.0;
		this.zedGraphControl1.Size = new System.Drawing.Size(688, 442);
		this.zedGraphControl1.TabIndex = 0;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(688, 442);
		base.Controls.Add(this.zedGraphControl1);
		base.Name = "DxSpotRateGraph";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "DX Spot Rate Graph";
		base.Load += new System.EventHandler(DxSpotRateGraph_Load);
		base.ResumeLayout(false);
	}
}
