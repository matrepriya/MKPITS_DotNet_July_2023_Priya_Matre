#include<iostream>
using namespace std;
class media_player
{
	public:
		virtual void play()=0;
		virtual void pause()=0;
		virtual void stop ()=0;
};
class audio_player:public media_player
{
	public:
		void start()
		{
			cout<<"video player play"<<endl;
		}
       void pause()
       {
       	cout<<"video player pause"<<endl;
	   }
	   void end()
	   {
	   	cout<<"vidoe player stop"<<endl;
	   }
};
class video_player:public media_player
{
	public:
		void start()
		{
			cout<<"video player_ play"<<endl;
		}
		void pause()
		{
			cout<<"vidoe player_pause"<<endl;
		}
		void end()
		{
			cout<<"video player-stop"<<endl;
		}
};
int main()
{
	audio_player a;
	a.play();
	a.pause();
	a.end();
	video_player v;
	v.play();
	v.pause();
	v.end();
	return 0;
}
