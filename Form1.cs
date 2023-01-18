using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Че_то
{
    public partial class Form1 : Form
    {
        Image[] enemies = new Image[5]; 
        int playerHp, playerStartedHp, playerResist, playerDmg, enemyHp, enemyResist, enemyDmg, killsCount, burning, queni;
        byte playerDmgPercent, enemyDmgPercent, playerDmgResistancePercent, enemyDmgResistancePercent, enemyImg, enemyImgNext, imgCount;
        byte enemyStartedHp;
        Random random = new Random();
        Random resistOrAttack = new Random();
        public Form1()
        {
            InitializeComponent();
            init();
        }
        /// <summary>
        /// Проводит первоначальную инициализацию
        /// </summary>
        /// <summary>
        /// Сбор заряда для ульты при атаке
        /// </summary>
        private void init()
        {
            killsCount = 0;
            writeKillsCount();
            imgCount = 5;
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = Image.FromFile($@"E:\Visual studio\проекты\Че-то\Resources\image{i}.jpg");
            }
            enemyImg = (byte)random.Next(0, imgCount);
            pictureBox2.Image = enemies[enemyImg];
            playerSpawn(out playerHp, out playerStartedHp, out playerResist, out playerDmg, ref random);
            enemySpawn(out enemyHp, out enemyStartedHp, out enemyResist, out enemyDmg, ref random);
            playerDmgPercent = getPlayerDmgPercent();
            enemyDmgPercent = getEnemyDmgPercent();
            playerDmgResistancePercent = getPlayerDmgResistancePercent();
            enemyDmgResistancePercent = getEnemyDmgResistancePercent();
            winBanner.Text = "";
            enemyEvent.Text = "";
            progressChargeAttack.Value = 0;
            igni.Image = Image.FromFile(@"E:\Visual studio\проекты\Че-то\Resources\igni.jpg");
            quen.Image = Image.FromFile(@"E:\Visual studio\проекты\Че-то\Resources\quen.jpg");
            shield.Visible = false;
            shield.Image = Image.FromFile(@"E:\Visual studio\проекты\Че-то\Resources\queni.jpg");
            fire.Visible = false;
            fire.Image = Image.FromFile(@"E:\Visual studio\проекты\Че-то\Resources\fire.png");
        }
        private void writeKillsCount()
        {
            killCounter.Text = $"Счетчик убийств: {killsCount}";
        }
        /// <summary>
        /// Спавнит противника со случайными параметрами
        /// </summary>
        /// <param name="enemyHp"></param>
        /// <param name="enemyResist"></param>
        /// <param name="enemyDmg"></param>
        /// <param name="random"></param>
        private void enemySpawn(out int enemyHp, out byte enemyStartedHp, out int enemyResist, out int enemyDmg, ref Random random)
        {
            enemyHp = random.Next(50, 250);
            enemyResist = random.Next(20, 60);
            enemyDmg = random.Next(10, 30);
            enemyHps.Text = $"Здоровье: {enemyHp}";
            enemyResistance.Text = $"Броня: {enemyResist}";
            enemyDamage.Text = $"Урон: {enemyDmg}";
            enemyHpProgressBar.Value = 100;
            enemyHpPercent.Text = "100% HP";
            enemyStartedHp = (byte)(enemyHp);
        }
        /// <summary>
        /// Спавнит игрока со случайными параметрами
        /// </summary>
        /// <param name="playerHp"></param>
        /// <param name="playerResist"></param>
        /// <param name="playerDmg"></param>
        /// <param name="random"></param>
        private void playerSpawn(out int playerHp, out int playerStartedHp, out int playerResist, out int playerDmg, ref Random random)
        {
            pictureBox1.Image = Image.FromFile(@"E:\Visual studio\проекты\Че-то\Resources\geralt.jpeg");
            playerHp = random.Next(200, 300);
            playerResist = random.Next(45, 60);
            playerDmg = random.Next(20, 45);
            playerHps.Text = $"Здоровье: {playerHp}";
            playerResistance.Text = $"Броня: {playerResist}";
            playerDamage.Text = $"Урон: {playerDmg}";
            playerHpProgressBar.Value = 100;
            playerHpPercent.Text = "100% HP";
            playerStartedHp = playerHp;
        }
        /// <summary>
        /// Собирает заряд для игни
        /// </summary>
        private void collectAttackCharge()
        {
            if ((progressChargeAttack.Value + 17) >= 100)
            {
                progressChargeAttack.Value = 100;
            }
            else
            {
                progressChargeAttack.Value += 17;
            }
        }
        /// <summary>
        /// Собирает заряд для квэн
        /// </summary>
        private void collectShieldCharge()
        {
            if (progressChargedShield.Value + 14 >= 100)
            {
                progressChargedShield.Value = 100;
            }
            else
            {
                progressChargedShield.Value += 14;
            }
        }
        /// <summary>
        /// Возвращает процент урона игрока от здоровья противника
        /// </summary>
        /// <returns></returns>
        private byte getPlayerDmgPercent()
        {
            return Convert.ToByte(playerDmg * 100 / enemyHp);
        }
        /// <summary>
        /// Возвращает процент урона игрока от здоровья противника при защите противника
        /// </summary>
        /// <returns></returns>
        private byte getPlayerDmgResistancePercent()
        {
            return Convert.ToByte((playerDmg - (playerDmg * enemyResist / 100)) * 100 / enemyHp);
        }
        /// <summary>
        /// Возвращает процент урона противника от здоровья игрока
        /// </summary>
        /// <returns></returns>
        private byte getEnemyDmgPercent()
        {
            return Convert.ToByte(enemyDmg * 100 / playerStartedHp);
        }
        /// <summary>
        /// Возвращает процент урона противника от здоровья игрока при защите игрока
        /// </summary>
        /// <returns></returns>
        private byte getEnemyDmgResistancePercent()
        {
            return Convert.ToByte((enemyDmg - (enemyDmg * playerResist / 100)) * 100 / playerStartedHp);
        }
        /// <summary>
        /// Выполнение требуемого кода при победе игрока
        /// </summary>
        private void endWinPlayer()
        {
            fire.Visible = false;
            burning = 0;
            killsCount++;
            writeKillsCount();
            winBanner.Text = "Вы победили!";
            enemyImgNext = (byte)random.Next(0, imgCount);
            if (enemyImgNext != enemyImg)
            {
                pictureBox2.Image = enemies[enemyImgNext];
                enemyImg = enemyImgNext;
            }
            else
            {
                while(enemyImg == enemyImgNext)
                {
                    enemyImgNext = (byte)random.Next(0, imgCount);
                }
                pictureBox2.Image = enemies[enemyImgNext];
                enemyImg = enemyImgNext;
            }
            enemySpawn(out enemyHp,out enemyStartedHp, out enemyResist, out enemyDmg, ref random);
            playerDmgPercent = getPlayerDmgPercent();
            enemyDmgPercent = getEnemyDmgPercent();
            playerDmgResistancePercent = getPlayerDmgResistancePercent();
            enemyDmgResistancePercent = getEnemyDmgResistancePercent();
        }
        /// <summary>
        /// Выполнение требуемого кода при победе противника
        /// </summary>
        private void endWinEnemy()
        {
            Restart.Visible = false;
            queni = 0;
            progressChargedShield.Value = 0;
            burning = 0;
            progressChargeAttack.Value = 0;
            winBanner.Text = $"Вы проиграли!\nРекорд: {killsCount}";
            killsCount = 0;
            writeKillsCount();
            playerSpawn(out playerHp, out playerStartedHp, out playerResist, out playerDmg, ref random);
            enemySpawn(out enemyHp, out enemyStartedHp, out enemyResist, out enemyDmg, ref random);
            playerDmgPercent = getPlayerDmgPercent();
            enemyDmgPercent = getEnemyDmgPercent();
            playerDmgResistancePercent = getPlayerDmgResistancePercent();
            enemyDmgResistancePercent = getEnemyDmgResistancePercent();
        }
        /// <summary>
        /// Отвечает за выполнение базовой атаки противника
        /// </summary>
        private void enemyBasicAttack()
        {
            playerHp -= enemyDmg;
            playerHps.Text = $"Здоровье: {playerHp}";
            playerHpProgressBar.Value -= enemyDmgPercent;
            playerHpPercent.Text = $"{playerHpProgressBar.Value}% HP";
            enemyEvent.Text = $"Противник атаковал вас\n-{enemyDmg} здоровья";
        }
        /// <summary>
        /// Отвечает за выполнение атаки противника в блок игрока
        /// </summary>
        private void enemyAttackWPlayerResist()
        {
            playerHp -= (enemyDmg - (enemyDmg * playerResist / 100));
            playerHps.Text = $"Здоровье: {playerHp}";
            playerHpProgressBar.Value -= enemyDmgResistancePercent;
            playerHpPercent.Text = $"{playerHpProgressBar.Value}% HP";
            enemyEvent.Text = $"Противник атаковал вас\n-{enemyDmg - (enemyDmg * playerResist / 100)} здоровья";
        }
        /// <summary>
        /// Отвечает за выполнение базовой атаки игрока
        /// </summary>
        private void playerBasicAttack()
        {
            enemyHp -= playerDmg;
            enemyHps.Text = $"Здоровье: {enemyHp}";
            enemyHpProgressBar.Value -= playerDmgPercent;
            enemyHpPercent.Text = $"{enemyHpProgressBar.Value}% HP";
            collectAttackCharge();
            burningCtrl();
        }
        /// <summary>
        /// Отвечает за выполнение атаки игрока в блок противника
        /// </summary>
        private void playerAttackWEnemyResist()
        {
            enemyHp -= (playerDmg - (playerDmg * enemyResist / 100));
            enemyHps.Text = $"Здоровье: {enemyHp}";
            enemyHpProgressBar.Value -= playerDmgResistancePercent;
            enemyHpPercent.Text = $"{enemyHpProgressBar.Value}% HP";
            enemyEvent.Text = $"Противник защитился\n-{playerDmg * enemyResist / 100} урона";
            collectAttackCharge();
            burningCtrl();
        }
        /// <summary>
        /// Наносит урон огнем равный 20
        /// </summary>
        private void burningCtrl()
        {
            if (burning > 0)
            {
                fire.Visible = true;
                if (enemyHp - 20 <= 0)
                {
                    endWinPlayer();
                    return;
                }
                enemyHp -= 20;
                enemyHps.Text = $"Здоровье: {enemyHp}";
                enemyHpProgressBar.Value -= 20*100/enemyStartedHp;
                enemyHpPercent.Text = $"{enemyHpProgressBar.Value}% HP";
                burning--;
            }
            else
            {
                fire.Visible=false;
                burning = 0;
            }
        }
        /// <summary>
        /// Контролирует работу квэна
        /// </summary>
        private void queniCtrl()
        {
            if (queni > 0)
            {
                shield.Visible = true;
                --queni;
            }
            else
            {
                shield.Visible = false;
                queni = 0;
            }
        }
        public void attackEnemy_Click(object sender, EventArgs e)
        {
            enemyEvent.Text = "";
            Restart.Visible = true;
            winBanner.Text = "";
            if (Convert.ToBoolean(resistOrAttack.Next(2)))
            {
                if (enemyHp - playerDmg <= 0)
                {
                    collectAttackCharge();
                    endWinPlayer();
                    return;
                }
                else if (playerHp - enemyDmg <= 0 && queni <= 0)
                {
                    endWinEnemy();
                    return;
                }
                if (queni <= 0)
                {
                    enemyBasicAttack();
                }
                queniCtrl();
                playerBasicAttack();
            }
            else
            {
                if (enemyHp - (playerDmg - (playerDmg * enemyResist / 100)) <= 0)
                {
                    collectAttackCharge();
                    endWinPlayer();
                    return;
                }
                queniCtrl();
                playerAttackWEnemyResist();
            }    
        }
        public void resistFromEnemy_Click(object sender, EventArgs e)
        {
            burningCtrl();
            Restart.Visible = true;
            winBanner.Text = "";
            if (Convert.ToBoolean(resistOrAttack.Next(2)))
            {
                if (playerHp - (enemyDmg - (enemyDmg * playerResist / 100)) <= 0 && queni <= 0)
                {
                    endWinEnemy();
                    return;
                }
                collectShieldCharge();
                if (queni <= 0)
                {
                    enemyAttackWPlayerResist();
                }
            }
            else
            {
                enemyEvent.Text = "Противник защитился";
            }
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            init();
            Restart.Visible = false;
        }
        private void igni_Click(object sender, EventArgs e)
        {
            if (progressChargeAttack.Value == 100)
            {
                progressChargeAttack.Value = 0;
                burning = 5;
                byte clearDmg = (byte)(playerStartedHp - playerDmg);
                byte igniDmg = (byte)(clearDmg - (clearDmg * enemyResist / 100));
                byte percentDmg = (byte)(igniDmg * 100 / enemyStartedHp);
                if (enemyHp - igniDmg <= 0)
                {
                    endWinPlayer();
                    return;
                }
                enemyHp -= igniDmg;
                enemyHps.Text = $"Здоровье: {enemyHp}";
                enemyHpProgressBar.Value -= percentDmg;
                enemyHpPercent.Text = $"{enemyHpProgressBar.Value} %HP";
            }
        }
        private void quen_Click(object sender, EventArgs e)
        {
            if(progressChargedShield.Value == 100)
            {
                shield.Visible = true;
                queni = 5;
                progressChargedShield.Value = 0;
            }
        }

    }
}
