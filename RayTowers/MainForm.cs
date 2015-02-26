// Purpose: The MainForm class to control the game.
// Author: Zhiyu Lei
// Date: 20/10/2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RayTowers
{
    public partial class MainForm : Form
    {
        private Board board; //private global references for a Board object
        private Disk selectedDiskObj; //private global references for the Disk being dragged  
        private int toPegNum; ///private global references for the Peg that is the target of the drop
        private bool gameSaved = true;       
        private Label[] lbl_Disks = new Label[4];
       

        private int animateLine = 0; //used to say which line in a list of moves is the current move
        private bool isStepping = false;
        //if moves are being made from a list, not by drag and drop
        //isStepping is used to prevent recording the moves made

        // Default constructor to intialize the main form
        public MainForm()
        {
            InitializeComponent();
            makeGame();
        }

        // To start a game
        public void makeGame()
        {
            Disk disk1 = new Disk(1, lbl_Disk1.Width, lbl_Disk1.BackColor, 1);
            Disk disk2 = new Disk(2, lbl_Disk2.Width, lbl_Disk2.BackColor, 1);
            Disk disk3 = new Disk(3, lbl_Disk3.Width, lbl_Disk3.BackColor, 1);
            Disk disk4 = new Disk(4, lbl_Disk4.Width, lbl_Disk4.BackColor, 1);
            board = new Board(disk1, disk2, disk3, disk4);

            lbl_Disks[0] = lbl_Disk1;
            lbl_Disks[1] = lbl_Disk2;
            lbl_Disks[2] = lbl_Disk3;
            lbl_Disks[3] = lbl_Disk4;
        }

        // Check (by asking the Board object) if a move can start when 
        // the user does a MouseDown on a disk label and give an error message if it cannot.
        private void anyDisk_MouseDown(object sender, MouseEventArgs e)
        {
            DragDropEffects result = DragDropEffects.None;

            Label lbl_Disk = sender as Label;
            selectedDiskObj = board.FindDisk(lbl_Disk);

            if (board.CanStartMove(selectedDiskObj))
            {
                result = lbl_Disk.DoDragDrop(0, DragDropEffects.All);
            }

            if (result != DragDropEffects.None)
            {
                ExecuteMove(lbl_Disk, selectedDiskObj.getDiskID());
            }
        }

        // Check (by asking the Board object) if a drop can happen on a Peg and only 
        // show the AllowDrop cursor when the mouse is over a Peg if a drop is valid.
        private void peg_DragEnter(object sender, DragEventArgs e)
        {
            Panel peg = sender as Panel;
            int chkPegNum = board.FindPegNum(peg);// checks move is valid
            if (board.CanDrop(selectedDiskObj, chkPegNum))
            {
                e.Effect = DragDropEffects.Move;
            }            
        }

        // DragDrop event which happens when the user releases the mouse button over the panel. 
        // In the event handler for this event we find the target peg number.
        private void peg_DragDrop(object sender, DragEventArgs e)
        {
            Panel peg = sender as Panel;
            toPegNum = board.FindPegNum(peg);
        }

        // Move a disk to a new Peg.
        public void ExecuteMove(Label alblDisk, int aDiskID)
        {
            Label lbl_Disk = alblDisk;
            int diskID = aDiskID;

            board.Move(diskID, toPegNum);

            Point newPt = new Point();
            newPt = board.Display(diskID, toPegNum); // calculates co-ordinates of new disk location
            lbl_Disk.Location = newPt;
            gameSaved = false;
            if (!isStepping)
            {
                MoveOutput(); // adds new move to text box
            }

            // check last move finished game
            bool gameFinished = board.GameFinished();
            if (gameFinished)
            {
                DisplayFinish();
            }
        }

        // Display a count of the moves made and show the moves made in a textbox, one line per move.
        public void MoveOutput()
        {
            txt_Moves.Clear();
            txt_Count.Clear();
            txt_Count.Text = (board.GetMoveCount()).ToString();
            txt_Moves.Text = board.AllMovesAsString();
        }

        // The program displays the message “You have successfully completed the game with the minimum number of moves” 
        // when all of the disks have been transferred to the third peg with the minimum number of moves.
        // The program displays the message “You have successfully completed the game but not with the minimum number of moves” 
        // when all of the disks have been transferred to the third peg with more than the minimum number of moves.
        public void DisplayFinish()
        {
            if (board.GetMoveCount() == 15)
            {
                MessageBox.Show("You have successfully completed the game with the minimum number of moves");
            }
            else if (board.GetMoveCount() > 15)
            {
                MessageBox.Show("You have successfully completed the game but not with the minimum number of moves");
            }
        }

        // Have a [Reset] button that creates 4 Disk objects matching the 4 labels
        // and a Board object, and then position the Disks in the starting position.
        private void btnReset_Click(object sender, EventArgs e)
        {
            Disk disk1 = new Disk(1, lbl_Disk1.Width, lbl_Disk1.BackColor, 1);
            Disk disk2 = new Disk(2, lbl_Disk2.Width, lbl_Disk2.BackColor, 1);
            Disk disk3 = new Disk(3, lbl_Disk3.Width, lbl_Disk3.BackColor, 1);
            Disk disk4 = new Disk(4, lbl_Disk4.Width, lbl_Disk4.BackColor, 1);

            // The [Reset] button will alter the global array of Disk objects 
            // to match the starting position of the disks.
            board = new Board(disk1, disk2, disk3, disk4);

            lbl_Disks[0] = lbl_Disk1;
            lbl_Disks[1] = lbl_Disk2;
            lbl_Disks[2] = lbl_Disk3;
            lbl_Disks[3] = lbl_Disk4;

            lbl_Disk1.Location = new Point(202, 144);
            lbl_Disk2.Location = new Point(192, 168);
            lbl_Disk3.Location = new Point(180, 192);
            lbl_Disk4.Location = new Point(170, 216);

            txt_Count.Clear();

            board.ResetBoard();

            animateLine = 0;
        }

        //repeat one of the moves stored in the textbox each time the timer fires
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animateLine >= txt_Moves.Lines.Length - 1)
            {
                 timer1.Enabled = false;
                 return;
            }
            else if (!MakeNextMove())
            {
                timer1.Enabled = false;
            }
        }

        //turn the timer on to begin animation of the moves stored in the textbox
        private void btnAnimate_Click(object sender, EventArgs e)
        {
            animateLine = 0;
            isStepping = true; //will prevent adding more moves to the textbox from the replay
            timer1.Enabled = true;
        }

        //repeat of the moves stored in the textbox one move at a time
        private void btnStep_Click(object sender, EventArgs e)
        {
            if (animateLine >= txt_Moves.Lines.Length - 1)
            {
                MessageBox.Show("Last available move has been completed");
                return;
            }
            MakeNextMove();         

        }

        //given a string with the .Name property of a disk
        //return a reference to that disk assuming that only valid names are passed
        private Label getDisk(string DiskName)        
        {

            if (DiskName == "1")
            {
                return lbl_Disk1;
            }
            else if (DiskName == "2")
            {
                return lbl_Disk2;
            }
            else if (DiskName == "3")
            {
                return lbl_Disk3;
            }
            else if (DiskName == "4")
            {
                return lbl_Disk4;
            }
            else return lbl_Disk2;
        }

        //repeat one of the moves stored in the textbox
        private bool MakeNextMove()        
        {
            try
            {
                String Move = txt_Moves.Lines[animateLine];
                String aMove = new string(Move.ToCharArray().Reverse().ToArray());
                
                String diskName = aMove.Substring(9, 1);
                Label lbl_Disk = getDisk(diskName);
                
                String pole = aMove.Substring(0, 1);
                int aPegNum = Convert.ToInt32(pole);
                
                String level = aMove.Substring(9, 1);
                int aDiskID = Convert.ToInt32(level);

                isStepping = true; //will prevent adding more moves to the textbox from the replay
                board.Move(aDiskID, aPegNum);
                Point newPt = board.Display(aDiskID, aPegNum);
                lbl_Disk.Location = newPt;
                
                isStepping = false;

                animateLine++;

                if (animateLine >= txt_Moves.Lines.Length)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }


        // Save a set of valid moves in a text file
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"S:\Moves.txt"))
            {
                sw.WriteLine(txt_Moves.Text);
                sw.Close();
            }
        
        }

        // Load a set of valid moves from a text file
        private void btnLoad_Click(object sender, EventArgs e)
        {
            txt_Moves.Clear();
            using(StreamReader sr = new StreamReader(@"S:\Moves.txt"))
            {
                while(!sr.EndOfStream)
                {
                   txt_Moves.AppendText(sr.ReadToEnd());
                }
                sr.Close();
            }
          
            animateLine = 0;
            isStepping = true; //will prevent adding more moves to the textbox from the replay
            timer2.Enabled = true;

        }

        // repeat one of the moves stored in the textbox each time the timer fires
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (animateLine >= txt_Moves.Lines.Length - 1)
            {
                timer2.Enabled = false;
                return;
            }
            else if (!MakeNextMove())
            {
                timer2.Enabled = false;
            }
        }




    }
}
