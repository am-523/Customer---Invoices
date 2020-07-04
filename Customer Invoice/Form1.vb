Imports System.Windows.Media
Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Public Class Form1
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub

    Private Sub DoughChart()

        PieChart1.InnerRadius = 70
        PieChart1.LegendLocation = LegendLocation.Right
        PieChart1.Series = New SeriesCollection From {
            New PieSeries With {
                .Title = "Clients",
                .Values = New ChartValues(Of Double) From {
                    8
                },
                .PushOut = 15,
                .DataLabels = True
            },
            New PieSeries With {
                .Title = "Project",
                .Values = New ChartValues(Of Double) From {
                    6
                },
                .DataLabels = True
            },
            New PieSeries With {
                .Title = "People",
                .Values = New ChartValues(Of Double) From {
                    10
                },
                .DataLabels = True
            },
            New PieSeries With {
                .Title = "Error",
                .Values = New ChartValues(Of Double) From {
                    4
                },
                .DataLabels = True
            }
        }

    End Sub

    Private Sub chartcolum()
        CartesianChart1.Series = New SeriesCollection From {
                New ColumnSeries With {
                    .Title = "2015",
                    .Values = New ChartValues(Of Double) From {
                        10,
                        50,
                        39,
                        50,
                        40,
                        60,
                        10,
                        35,
                        70,
                        40,
                        60,
                        10,
                        35
                    }
                }
            }
        CartesianChart1.Series.Add(New ColumnSeries With {
            .Title = "2016",
            .Values = New ChartValues(Of Double) From {
                11,
                56,
                42,
                  40,
                        60,
                        10,
                        35,
                        70,
                        40,
                        60,
                        10,
                        35
            }
        })
        CartesianChart1.Series(1).Values.Add(48.0R)
        CartesianChart1.AxisX.Add(New Axis With {
            .Title = "Sales Man",
            .Labels = {"Maria", "Susan", "Charles", "Frida", "Jaenab", "Roma", "Ferdinand", "Asril", "Jaenab", "Roma", "Ferdinand", "Asril"}
        })
        CartesianChart1.AxisY.Add(New Axis With {
            .Title = "Sold Apps",
            .LabelFormatter = Function(value) value.ToString("N")
        })
    End Sub

    Private Sub listorder()


        Guna2DataGridView1.Rows.Add(4)
        Guna2DataGridView1.Rows(0).Cells(0).Value = 0
        Guna2DataGridView1.Rows(0).Cells(1).Value = "Comelune RT"
        Guna2DataGridView1.Rows(0).Cells(2).Value = "7 July 2020,04:10 AM"
        Guna2DataGridView1.Rows(0).Cells(3).Value = "Private"
        Guna2DataGridView1.Rows(0).Cells(4).Value = "10093 - 38294"
        Guna2DataGridView1.Rows(0).Cells(5).Value = "$2,500.00"
        Guna2DataGridView1.Rows(0).Cells(6).Value = "Paid"



        Guna2DataGridView1.Rows(1).Cells(0).Value = 0
        Guna2DataGridView1.Rows(1).Cells(1).Value = "Diagnose Case"
        Guna2DataGridView1.Rows(1).Cells(2).Value = "7 July 2020,04:10 AM"
        Guna2DataGridView1.Rows(1).Cells(3).Value = "Bill Payment"
        Guna2DataGridView1.Rows(1).Cells(4).Value = "10093 - 38294"
        Guna2DataGridView1.Rows(1).Cells(5).Value = "$4,500.00"
        Guna2DataGridView1.Rows(1).Cells(6).Value = "Past Due"


        Guna2DataGridView1.Rows(2).Cells(0).Value = 0
        Guna2DataGridView1.Rows(2).Cells(1).Value = "Saturan Flow"
        Guna2DataGridView1.Rows(2).Cells(2).Value = "2 July 2020,04:10 AM"
        Guna2DataGridView1.Rows(2).Cells(3).Value = "Private"
        Guna2DataGridView1.Rows(2).Cells(4).Value = "10093 - 38294"
        Guna2DataGridView1.Rows(2).Cells(5).Value = "$4,500.00"
        Guna2DataGridView1.Rows(2).Cells(6).Value = "Paid"


        Guna2DataGridView1.Rows(3).Cells(0).Value = 0
        Guna2DataGridView1.Rows(3).Cells(1).Value = "Engine Case"
        Guna2DataGridView1.Rows(3).Cells(2).Value = "8 June 2020,04:10 AM"
        Guna2DataGridView1.Rows(3).Cells(3).Value = "Private"
        Guna2DataGridView1.Rows(3).Cells(4).Value = "10093 - 38294"
        Guna2DataGridView1.Rows(3).Cells(5).Value = "$4,500.00"
        Guna2DataGridView1.Rows(3).Cells(6).Value = "Paid"


        Guna2DataGridView1.Rows(4).Cells(0).Value = 0
        Guna2DataGridView1.Rows(4).Cells(1).Value = "Erro Human"
        Guna2DataGridView1.Rows(4).Cells(2).Value = "1 July 2020,04:10 AM"
        Guna2DataGridView1.Rows(4).Cells(3).Value = "Bill Payment"
        Guna2DataGridView1.Rows(4).Cells(4).Value = "10093 - 38294"
        Guna2DataGridView1.Rows(4).Cells(5).Value = "$4,500.00"
        Guna2DataGridView1.Rows(4).Cells(6).Value = "Past Due"


        Dim combo As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn()
        combo.HeaderText = "ACTION"
        combo.Items.Add("Copy")
        combo.Items.Add("Send Email")
        combo.Items.Add("Delete")
        combo.Items.Add("Edit")
        Guna2DataGridView1.Columns.Add(combo)







    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoughChart()
        chartcolum()
        listorder()
    End Sub
End Class
