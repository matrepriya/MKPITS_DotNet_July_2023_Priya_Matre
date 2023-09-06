
#include<iostream>
using namespace std;
class media_player
{
	public:
		virtual void play()=0;
		virtual void pause()=0;
		virtual void end()=0;
};
class audio_player:public media_player
{
	public:
		void play()
		{
			cout<<"audio player play"<<endl;
		}
       void pause()
       {
       	cout<<"audio player pause"<<endl;
	   }
	   void end()
	   {
	   	cout<<"audio player stop"<<endl;
	   }
};
class video_player:public media_player
{
	public:
		void play()
		{
			cout<<"video player play"<<endl;
		}
		void pause()
		{
			cout<<"vidoe player pause"<<endl;
		}
		void end()
		{
			cout<<"video player stop"<<endl;
		}
};
int main()
{
	audio_player a;
	a.play();
	a.pause();
	a.end();
	cout<<"------------------------------------"<<endl;
	video_player v;
	v.play();
	v.pause();
	v.end();
	return 0;
}

