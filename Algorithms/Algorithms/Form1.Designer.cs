namespace Algorithms
{
    partial class Algorithms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.Algorithm = new System.Windows.Forms.ListBox();
            this.textOutput = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.Queue = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.strings = new System.Windows.Forms.TabPage();
            this.graphs = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.graphEndNode = new System.Windows.Forms.TextBox();
            this.graphStartNode = new System.Windows.Forms.TextBox();
            this.undirected = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edgeWeight = new System.Windows.Forms.TextBox();
            this.graphEdges = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.graphOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.graphNodes = new System.Windows.Forms.ListBox();
            this.graphInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.strings.SuspendLayout();
            this.graphs.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.Linen;
            this.input.Location = new System.Drawing.Point(51, 212);
            this.input.MaxLength = 100;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(507, 38);
            this.input.TabIndex = 1;
            // 
            // Algorithm
            // 
            this.Algorithm.BackColor = System.Drawing.Color.Linen;
            this.Algorithm.FormattingEnabled = true;
            this.Algorithm.ItemHeight = 31;
            this.Algorithm.Items.AddRange(new object[] {
            "Echo",
            "Remove Duplicate Letters",
            "Reverse",
            "Detect Palindrome",
            "Remove Whitespace",
            "To Lower Case"});
            this.Algorithm.Location = new System.Drawing.Point(858, 153);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(465, 97);
            this.Algorithm.TabIndex = 3;
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.Color.Linen;
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textOutput.Location = new System.Drawing.Point(57, 476);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(501, 42);
            this.textOutput.TabIndex = 4;
            this.textOutput.Text = "                   ";
            this.textOutput.Click += new System.EventHandler(this.output_Click);
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.Linen;
            this.go.Location = new System.Drawing.Point(732, 476);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(134, 109);
            this.go.TabIndex = 5;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Output";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input";
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Linen;
            this.remove.Location = new System.Drawing.Point(1363, 293);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(198, 103);
            this.remove.TabIndex = 8;
            this.remove.Text = "Remove from Queue";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Queue
            // 
            this.Queue.BackColor = System.Drawing.Color.Linen;
            this.Queue.FormattingEnabled = true;
            this.Queue.ItemHeight = 31;
            this.Queue.Location = new System.Drawing.Point(858, 293);
            this.Queue.Name = "Queue";
            this.Queue.Size = new System.Drawing.Size(465, 97);
            this.Queue.TabIndex = 7;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Linen;
            this.add.Location = new System.Drawing.Point(1363, 153);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(181, 97);
            this.add.TabIndex = 6;
            this.add.Text = "Add to Queue";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.strings);
            this.tabControl1.Controls.Add(this.graphs);
            this.tabControl1.Location = new System.Drawing.Point(33, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1618, 765);
            this.tabControl1.TabIndex = 7;
            // 
            // strings
            // 
            this.strings.BackColor = System.Drawing.Color.LightSkyBlue;
            this.strings.Controls.Add(this.label2);
            this.strings.Controls.Add(this.Algorithm);
            this.strings.Controls.Add(this.label1);
            this.strings.Controls.Add(this.go);
            this.strings.Controls.Add(this.remove);
            this.strings.Controls.Add(this.textOutput);
            this.strings.Controls.Add(this.Queue);
            this.strings.Controls.Add(this.input);
            this.strings.Controls.Add(this.add);
            this.strings.Location = new System.Drawing.Point(10, 48);
            this.strings.Name = "strings";
            this.strings.Padding = new System.Windows.Forms.Padding(3);
            this.strings.Size = new System.Drawing.Size(1598, 707);
            this.strings.TabIndex = 0;
            this.strings.Text = "strings";
            // 
            // graphs
            // 
            this.graphs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.graphs.Controls.Add(this.label9);
            this.graphs.Controls.Add(this.label7);
            this.graphs.Controls.Add(this.graphEndNode);
            this.graphs.Controls.Add(this.graphStartNode);
            this.graphs.Controls.Add(this.undirected);
            this.graphs.Controls.Add(this.label8);
            this.graphs.Controls.Add(this.edgeWeight);
            this.graphs.Controls.Add(this.graphEdges);
            this.graphs.Controls.Add(this.button4);
            this.graphs.Controls.Add(this.graphOutput);
            this.graphs.Controls.Add(this.label6);
            this.graphs.Controls.Add(this.label5);
            this.graphs.Controls.Add(this.label4);
            this.graphs.Controls.Add(this.button3);
            this.graphs.Controls.Add(this.button2);
            this.graphs.Controls.Add(this.button1);
            this.graphs.Controls.Add(this.label3);
            this.graphs.Controls.Add(this.graphNodes);
            this.graphs.Controls.Add(this.graphInput);
            this.graphs.Location = new System.Drawing.Point(10, 48);
            this.graphs.Name = "graphs";
            this.graphs.Padding = new System.Windows.Forms.Padding(3);
            this.graphs.Size = new System.Drawing.Size(1598, 707);
            this.graphs.TabIndex = 1;
            this.graphs.Text = "graphs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(862, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "End Node";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(862, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Start Node";
            // 
            // graphEndNode
            // 
            this.graphEndNode.Location = new System.Drawing.Point(862, 393);
            this.graphEndNode.Name = "graphEndNode";
            this.graphEndNode.Size = new System.Drawing.Size(100, 38);
            this.graphEndNode.TabIndex = 18;
            // 
            // graphStartNode
            // 
            this.graphStartNode.Location = new System.Drawing.Point(862, 310);
            this.graphStartNode.Name = "graphStartNode";
            this.graphStartNode.Size = new System.Drawing.Size(100, 38);
            this.graphStartNode.TabIndex = 17;
            // 
            // undirected
            // 
            this.undirected.AutoSize = true;
            this.undirected.Location = new System.Drawing.Point(442, 298);
            this.undirected.Name = "undirected";
            this.undirected.Size = new System.Drawing.Size(187, 36);
            this.undirected.TabIndex = 16;
            this.undirected.Text = "undirected";
            this.undirected.UseVisualStyleBackColor = true;
            this.undirected.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(317, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Edge Weight (Default 1)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // edgeWeight
            // 
            this.edgeWeight.Location = new System.Drawing.Point(406, 82);
            this.edgeWeight.Name = "edgeWeight";
            this.edgeWeight.Size = new System.Drawing.Size(100, 38);
            this.edgeWeight.TabIndex = 14;
            // 
            // graphEdges
            // 
            this.graphEdges.FormattingEnabled = true;
            this.graphEdges.ItemHeight = 31;
            this.graphEdges.Location = new System.Drawing.Point(49, 465);
            this.graphEdges.Name = "graphEdges";
            this.graphEdges.Size = new System.Drawing.Size(331, 190);
            this.graphEdges.TabIndex = 13;
            this.graphEdges.SelectedIndexChanged += new System.EventHandler(this.graphEdges_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1129, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 101);
            this.button4.TabIndex = 12;
            this.button4.Text = "runAlgorithm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // graphOutput
            // 
            this.graphOutput.AutoSize = true;
            this.graphOutput.BackColor = System.Drawing.Color.Snow;
            this.graphOutput.Location = new System.Drawing.Point(507, 594);
            this.graphOutput.Name = "graphOutput";
            this.graphOutput.Size = new System.Drawing.Size(101, 32);
            this.graphOutput.TabIndex = 11;
            this.graphOutput.Text = "Output";
            this.graphOutput.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1155, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dijkstra\'s Algorithm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nodes";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1186, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(340, 75);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(882, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 75);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add to Edges";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add to nodes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input";
            // 
            // graphNodes
            // 
            this.graphNodes.FormattingEnabled = true;
            this.graphNodes.ItemHeight = 31;
            this.graphNodes.Location = new System.Drawing.Point(43, 210);
            this.graphNodes.Name = "graphNodes";
            this.graphNodes.Size = new System.Drawing.Size(337, 159);
            this.graphNodes.TabIndex = 1;
            this.graphNodes.SelectedIndexChanged += new System.EventHandler(this.graphNodes_SelectedIndexChanged);
            // 
            // graphInput
            // 
            this.graphInput.Location = new System.Drawing.Point(43, 112);
            this.graphInput.Name = "graphInput";
            this.graphInput.Size = new System.Drawing.Size(323, 38);
            this.graphInput.TabIndex = 0;
            this.graphInput.TextChanged += new System.EventHandler(this.graphInput_TextChanged);
            // 
            // Algorithms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(3184, 1501);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Algorithms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.strings.ResumeLayout(false);
            this.strings.PerformLayout();
            this.graphs.ResumeLayout(false);
            this.graphs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.ListBox Algorithm;
        private System.Windows.Forms.Label textOutput;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ListBox Queue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage strings;
        private System.Windows.Forms.TabPage graphs;
        private System.Windows.Forms.TextBox graphInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox graphNodes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label graphOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox graphEdges;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edgeWeight;
        private System.Windows.Forms.CheckBox undirected;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox graphEndNode;
        private System.Windows.Forms.TextBox graphStartNode;
    }
}

