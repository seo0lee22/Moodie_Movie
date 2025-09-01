using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moodie_Movie
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> movieDict;

        public Form1()
        {
            InitializeComponent();
            InitializeMovieData();
        }

        private void InitializeMovieData()
        {
            movieDict = new Dictionary<string, string>
            {
                { "기쁨", "《라라랜드》: 재즈 피아니스트와 배우 지망생의 사랑과 꿈이 교차하는 청춘 드라마.\n《인사이드 아웃》: 감정들이 한 소녀의 마음속에서 벌이는 따뜻하고 유쾌한 모험." },
                { "설렘", "《비긴 어게인》: 음악을 통해 서로의 상처를 치유하는 두 사람의 우연한 만남.\n《콜 미 바이 유어 네임》: 첫사랑의 강렬한 설렘과 성장의 순간을 담은 여름 이야기." },
                { "평온", "《리틀 포레스트》: 도시를 떠나 자연 속에서 삶을 회복하는 청춘의 이야기.\n《패터슨》: 시를 쓰며 일상 속 소소한 행복을 찾아가는 버스 기사 이야기." },
                { "신남", "《맘마 미아!》: 아바 음악과 함께 펼쳐지는 유쾌한 가족 뮤지컬.\n《스쿨 오브 락》: 열정적인 록 음악으로 아이들과 함께 성장하는 좌충우돌 코미디." },
                { "슬픔", "《노트북》: 세월을 넘어 이어지는 애절하고 순수한 사랑 이야기.\n《마이 걸》: 소녀의 성장과 첫사랑의 아픔을 그린 눈물 어린 드라마." },
                { "분노", "《존 윅》: 모든 것을 잃은 남자가 펼치는 처절한 복수극.\n《매드 맥스: 분노의 도로》: 혼돈의 세상에서 자유를 향한 거친 질주." },
                { "우울", "《이터널 선샤인》: 지우고 싶은 기억과 남기고 싶은 사랑 사이의 갈등.\n《월터의 상상은 현실이 된다》: 평범한 일상을 모험으로 바꾸며 자기 자신을 회복하는 이야기." },
                
                // 2개 감정 조합
                { "기쁨 + 설렘", "《주토피아》: 편견을 넘어 꿈을 이루는 유쾌한 모험 이야기.\n《해리 포터와 마법사의 돌》: 마법 세계에 첫발을 내딛는 소년의 설렘과 모험." },
                { "기쁨 + 평온", "《인생은 아름다워》: 전쟁 속에서도 아들을 웃게 하려는 아버지의 사랑.\n《업》: 새로운 시작을 향해 떠나는 감동적인 모험." },
                { "기쁨 + 신남", "《코코》: 음악과 가족을 통해 꿈과 정체성을 찾아가는 소년의 여정.\n《싱 스트리트》: 음악으로 세상과 맞서는 청춘들의 성장 이야기." },
                { "기쁨 + 슬픔", "《포레스트 검프》: 평범하지만 특별한 인생을 살아가는 한 남자의 여정.\n《인생은 아름다워》: 웃음 속에 숨은 깊은 눈물과 희망의 이야기." },
                { "기쁨 + 분노", "《트루먼 쇼》: 진실을 찾아 세상과 맞서는 한 남자의 이야기.\n《머니볼》: 편견과 싸우며 새로운 방식을 개척하는 야구단 이야기." },
                { "기쁨 + 우울", "《어바웃 타임》: 시간을 되돌리며 사랑과 가족의 소중함을 깨닫는 청춘 이야기.\n《500일의 썸머》: 현실적이면서도 사랑스러운 연애의 희로애락." },

                { "설렘 + 평온", "《그 해 우리는》: 시간이 흘러도 이어지는 청춘의 인연과 회복.\n《일 포스티노》: 시와 편지로 이어지는 아름다운 우정과 삶의 여유." },
                { "설렘 + 신남", "《라라랜드》: 꿈과 사랑 속에서 빛나는 두 청춘의 순간.\n《위대한 쇼맨》: 모두가 주인공이 되는 무대를 만드는 남자의 이야기." },
                { "설렘 + 슬픔", "《원데이》: 같은 날, 다른 시간에 이어지는 두 사람의 인연.\n《타이타닉》: 운명적 만남과 비극적 이별을 그린 사랑 이야기." },
                { "설렘 + 분노", "《헝거게임》: 불의에 맞서 희망을 불러일으키는 소녀의 반란.\n《스파이더맨: 홈커밍》: 영웅으로 성장하는 소년의 설렘과 도전." },
                { "설렘 + 우울", "《500일의 썸머》: 사랑의 시작과 끝을 바라보는 씁쓸한 성장 드라마.\n《비포 선셋》: 헤어진 연인이 다시 만나며 떠오르는 감정의 여운." },

                { "평온 + 신남", "《월-E》: 우주에서 피어난 순수하고 따뜻한 사랑과 희망.\n《굿 윌 헌팅》: 삶의 의미를 찾아가는 청년과 교수의 만남." },
                { "평온 + 슬픔", "《그린 마일》: 특별한 능력을 가진 죄수와 교도관의 감동적 우정.\n《블루 발렌타인》: 사랑의 시작과 끝을 담담히 보여주는 드라마." },
                { "평온 + 분노", "《아바타》: 파괴와 탐욕 속에서 자연과 조화를 지키려는 싸움.\n《에린 브로코비치》: 평범한 여성이 거대 기업에 맞서는 실화 이야기." },
                { "평온 + 우울", "《her》: 외로운 남자가 AI와 나누는 특별한 사랑 이야기.\n《가버나움》: 가난 속에서도 희망을 찾아가는 소년의 여정." },

                { "신남 + 슬픔", "《빌리 엘리어트》: 가난 속에서도 발레를 향한 열정을 지키는 소년.\n《위플래쉬》: 혹독한 훈련 속에서도 음악을 향한 열정을 불태우는 청춘." },
                { "신남 + 분노", "《베이비 드라이버》: 음악과 스피드로 세상을 돌파하는 한 청년.\n《킹스맨》: 통쾌한 액션과 유머가 어우러진 스파이 모험." },
                { "신남 + 우울", "《가디언즈 오브 갤럭시》: 유머와 상처를 가진 이들이 팀이 되어 우주를 구하는 이야기.\n《리틀 미스 선샤인》: 가족이 함께 성장하는 웃음과 눈물의 여정." },

                { "슬픔 + 분노", "《맨체스터 바이 더 씨》: 상실의 아픔 속에서 살아가는 남자의 이야기.\n《밀양》: 비극 속에서 용서를 찾으려는 여성의 여정." },
                { "슬픔 + 우울", "《레퀴엠》: 중독과 절망에 무너지는 청춘들의 비극.\n《룸》: 감금에서 벗어나 세상과 마주하는 모자의 이야기." },

                { "분노 + 우울", "《조커》: 사회에 버려진 한 남자가 광대로 각성하며 폭발하는 이야기.\n《파이트 클럽》: 분노와 허무 속에서 정체성을 찾으려는 남자의 투쟁." },

                // 3개 감정 조합
                { "기쁨 + 설렘 + 평온", "《리틀 포레스트》: 일상 속 자연과 요리를 통해 마음을 회복하는 청춘 이야기.\n《비포 선라이즈》: 낯선 도시에서 하루 동안 이어지는 두 사람의 대화와 설렘." },
                { "기쁨 + 설렘 + 신남", "《라라랜드》: 꿈과 사랑 속에서 빛나는 두 청춘의 순간.\n《위대한 쇼맨》: 모두가 주인공이 되는 무대를 만들어낸 쇼맨의 여정." },
                { "기쁨 + 설렘 + 슬픔", "《포레스트 검프》: 평범하지만 특별한 인생을 살아가는 한 남자의 여정.\n《인생은 아름다워》: 웃음 속에 숨은 깊은 눈물과 희망의 이야기." },
                { "기쁨 + 설렘 + 분노", "《트루먼 쇼》: 진실을 찾아 세상과 맞서는 한 남자의 이야기.\n《헝거게임》: 불의에 맞서 희망을 불러일으키는 소녀의 반란." },
                { "기쁨 + 설렘 + 우울", "《어바웃 타임》: 시간을 되돌리며 사랑과 가족의 소중함을 깨닫는 청춘 이야기.\n《500일의 썸머》: 현실적이면서도 사랑스러운 연애의 희로애락." },

                { "기쁨 + 평온 + 신남", "《월-E》: 우주에서 피어난 순수하고 따뜻한 사랑과 희망.\n《굿 윌 헌팅》: 삶의 의미를 찾아가는 청년과 교수의 만남." },
                { "기쁨 + 평온 + 슬픔", "《업》: 새로운 시작을 향해 떠나는 감동적인 모험과 삶의 여유.\n《그린 마일》: 특별한 능력을 가진 죄수와 교도관의 감동적 우정." },
                { "기쁨 + 평온 + 분노", "《인생은 아름다워》: 전쟁 속에서도 웃음을 잃지 않으려는 한 남자의 노력.\n《아바타》: 파괴와 탐욕 속에서 자연과 조화를 지키려는 싸움." },
                { "기쁨 + 평온 + 우울", "《어바웃 타임》: 시간을 되돌리며 삶의 소중함을 깨닫는 이야기.\n《her》: 외로운 남자가 AI와 나누는 특별한 사랑 이야기." },

                { "기쁨 + 신남 + 슬픔", "《코코》: 음악과 가족을 통해 꿈과 정체성을 찾아가는 소년의 여정.\n《위플래쉬》: 혹독한 훈련 속에서도 음악을 향한 열정을 불태우는 청춘." },
                { "기쁨 + 신남 + 분노", "《베이비 드라이버》: 음악과 스피드로 세상을 돌파하는 한 청년.\n《킹스맨》: 통쾌한 액션과 유머가 어우러진 스파이 모험." },
                { "기쁨 + 신남 + 우울", "《가디언즈 오브 갤럭시》: 유머와 상처를 가진 이들이 팀이 되어 우주를 구하는 이야기.\n《리틀 미스 선샤인》: 가족이 함께 성장하는 웃음과 눈물의 여정." },

                { "기쁨 + 슬픔 + 분노", "《트루먼 쇼》: 진실과 정의를 찾아 싸우는 한 남자의 갈등.\n《맨체스터 바이 더 씨》: 상실과 분노 속에서 삶을 이어가는 남자의 이야기." },
                { "기쁨 + 슬픔 + 우울", "《어바웃 타임》: 사랑과 상실을 동시에 마주하며 성장하는 이야기.\n《이터널 선샤인》: 지우고 싶은 기억과 남기고 싶은 사랑 사이의 갈등." },

                { "기쁨 + 분노 + 우울", "《조커》: 사회에 버려진 한 남자가 광대로 각성하며 폭발하는 이야기.\n《파이트 클럽》: 분노와 허무 속에서 정체성을 찾으려는 남자의 투쟁." },

                { "설렘 + 평온 + 신남", "《라라랜드》: 꿈과 사랑 속에서 빛나는 순간.\n《위대한 쇼맨》: 모두가 주인공이 되는 무대를 만들어낸 이야기." },
                { "설렘 + 평온 + 슬픔", "《그 해 우리는》: 시간이 흘러도 이어지는 청춘의 인연과 회복.\n《일 포스티노》: 시와 편지로 이어지는 아름다운 우정과 삶의 여유." },
                { "설렘 + 평온 + 분노", "《아바타》: 자연과 조화를 지키려는 싸움과 모험.\n《에린 브로코비치》: 평범한 여성이 거대 기업에 맞서는 실화." },
                { "설렘 + 평온 + 우울", "《her》: 외로운 남자가 AI와 나누는 특별한 사랑 이야기.\n《가버나움》: 가난 속에서도 희망을 찾아가는 소년의 이야기." },

                { "설렘 + 신남 + 슬픔", "《원데이》: 같은 날, 다른 시간에 이어지는 두 사람의 인연.\n《타이타닉》: 운명적 만남과 비극적 이별을 그린 사랑 이야기." },
                { "설렘 + 신남 + 분노", "《헝거게임》: 불의에 맞서 희망을 불러일으키는 소녀의 반란.\n《스파이더맨: 홈커밍》: 영웅으로 성장하는 소년의 설렘과 도전." },
                { "설렘 + 신남 + 우울", "《500일의 썸머》: 사랑의 시작과 끝을 바라보는 씁쓸한 성장 드라마.\n《비포 선셋》: 헤어진 연인이 다시 만나며 떠오르는 감정의 여운." },

                { "설렘 + 슬픔 + 분노", "《맨체스터 바이 더 씨》: 상실과 분노 속에서 삶을 이어가는 남자의 이야기.\n《밀양》: 비극 속에서 용서를 찾으려는 여성의 여정." },
                { "설렘 + 슬픔 + 우울", "《레퀴엠》: 중독과 절망에 무너지는 청춘들의 비극.\n《룸》: 감금에서 벗어나 세상과 마주하는 모자의 이야기." },

                { "설렘 + 분노 + 우울", "《조커》: 사회에 버려진 한 남자가 광대로 각성하며 폭발하는 이야기.\n《파이트 클럽》: 분노와 허무 속에서 정체성을 찾으려는 남자의 투쟁." },

                { "평온 + 신남 + 슬픔", "《월-E》: 우주에서 피어난 순수하고 따뜻한 사랑과 희망.\n《리틀 포레스트》: 자연 속에서 일상과 마음을 회복하는 이야기." },
                { "평온 + 신남 + 분노", "《아바타》: 자연과 조화를 지키려는 싸움과 모험.\n《에린 브로코비치》: 평범한 여성이 거대 기업에 맞서는 실화." },
                { "평온 + 신남 + 우울", "《가디언즈 오브 갤럭시》: 유머와 상처를 가진 이들이 팀이 되어 우주를 구하는 이야기.\n《리틀 미스 선샤인》: 가족이 함께 성장하는 웃음과 눈물의 여정." },

                { "평온 + 슬픔 + 분노", "《맨체스터 바이 더 씨》: 상실과 분노 속에서 삶을 이어가는 남자의 이야기.\n《밀양》: 비극 속에서 용서를 찾으려는 여성의 여정." },
                { "평온 + 슬픔 + 우울", "《레퀴엠》: 중독과 절망에 무너지는 청춘들의 비극.\n《룸》: 감금에서 벗어나 세상과 마주하는 모자의 이야기." },

                { "평온 + 분노 + 우울", "《조커》: 사회에 버려진 한 남자가 광대로 각성하며 폭발하는 이야기.\n《파이트 클럽》: 분노와 허무 속에서 정체성을 찾으려는 남자의 투쟁." },

                { "신남 + 슬픔 + 분노", "《위플래쉬》: 혹독한 훈련 속에서도 음악을 향한 열정을 불태우는 청춘.\n《빌리 엘리어트》: 가난 속에서도 발레를 향한 열정을 지키는 소년." },
                { "신남 + 슬픔 + 우울", "《리틀 미스 선샤인》: 가족이 함께 성장하는 웃음과 눈물의 여정.\n《가버나움》: 가난 속에서도 희망을 찾아가는 소년의 이야기." },

                { "신남 + 분노 + 우울", "《조커》: 사회에 버려진 한 남자가 광대로 각성하며 폭발하는 이야기.\n《파이트 클럽》: 분노와 허무 속에서 정체성을 찾으려는 남자의 투쟁." },

                { "슬픔 + 분노 + 우울", "《조커》: 사회적 억압과 상실 속에서 광기로 각성하는 한 남자.\n《맨체스터 바이 더 씨》: 상실과 분노 속에서 삶을 이어가는 남자의 이야기." },
            };
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void dToolStripMenuItem1_Click(object sender, EventArgs e) { }
        private void 끝내기ToolStripMenuItem1_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 표츈텔러정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout from = new FormAbout();
            from.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbname.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }

            List<string> selectedEmotions = new List<string>();
            if (check_happe.Checked) selectedEmotions.Add("기쁨");
            if (check_sad.Checked) selectedEmotions.Add("슬픔");
            if (check_excitement.Checked) selectedEmotions.Add("설렘");
            if (check_tranquility.Checked) selectedEmotions.Add("평온");
            if (check_melancholy.Checked) selectedEmotions.Add("우울");
            if (check_excited.Checked) selectedEmotions.Add("신남");
            if (check_anger.Checked) selectedEmotions.Add("분노");

            if (selectedEmotions.Count == 0)
            {
                MessageBox.Show("최소 1개의 감정을 선택해주세요.");
                return;
            }
            else if (selectedEmotions.Count > 3)
            {
                MessageBox.Show("최대 3개의 감정만 선택 가능합니다.");
                return;
            }

            selectedEmotions.Sort();
            string key = string.Join(" + ", selectedEmotions);

            string result = "";
            if (movieDict.ContainsKey(key))
            {
                result = movieDict[key];
            }
            else
            {
                List<string> singleEmotionMovies = new List<string>();
                foreach (var emo in selectedEmotions)
                {
                    if (movieDict.ContainsKey(emo))
                    {
                        singleEmotionMovies.Add(movieDict[emo]);
                    }
                }
                result = string.Join("\n\n", singleEmotionMovies);
            }

            tbResult.Text = $"{name}님은 {key}을(를) 느끼셨군요.\n제가 추천해 드릴 영화는\n\n{result}\n\n입니다.";
        }

        private void result_list_Click(object sender, EventArgs e)
        {
            AllResult all = new AllResult();
            all.ShowDialog();
        }

        private void tbname_TextChanged(object sender, EventArgs e) { }
        private void check_happe_CheckedChanged(object sender, EventArgs e) { }
        private void check_sad_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void check_excitement_CheckedChanged(object sender, EventArgs e) { }
        private void check_tranquility_CheckedChanged(object sender, EventArgs e) { }
        private void check_melancholy_CheckedChanged(object sender, EventArgs e) { }
        private void check_excited_CheckedChanged(object sender, EventArgs e) { }
        private void tbResult_TextChanged(object sender, EventArgs e) { }
        private void check_anger_CheckedChanged(object sender, EventArgs e) { }
    }
}