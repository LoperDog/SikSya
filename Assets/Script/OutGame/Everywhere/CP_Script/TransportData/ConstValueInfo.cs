﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConstValueInfo
{
    //public enum State
    //{
    //    Login,
    //    Join,
    //    Room
    //}

    public enum ProtocolInfo       // 대분류
    {
        None,               // 초기화 값
        ServerCommend,      // 서버에게 명령
        ChattingMessage,    // 채팅 메세지
        ClientCommend,       // 클라이언트 명령
        RequestResult,       // 요청 결과
        SceneChange,         // 씬 변경
        ExitGameProcess,
        RoomInfo
        //PlayerInfo          // 플레이어 정보( 캐릭터, 이름 )
    }

    public enum ProtocolDetail     // 중분류
    {
        NoneDetail,               // 초기화 값
        Message,            // 메세지
        ImageChange,              // 이미지
        NameChange,               // 이름
        EnterRoom,
        EnterSpecialRoom,
        EnterChanel,
        MakeRoom,
        OutRoom,
        OutMakeRoom,
        SetReadyGame,           // 게임준비
        FrontMenu,              // 메뉴(로그인, 회원가입, 게스트 로그인 )
        ChangeCharacter,        // 캐릭터 변경
        NotReadyGame,           // 게임 준비 취소
        StartGame,
        GetHostIP,
        SuccessRequest,       // 요청 성공
        FailRequest,            // 요청 실패
        RemovePanel,             // 나간 사람 패널 지우기
        MyInfoImage,                 // 내정보
        MyInfoName,
        OutMainGameScene,        // 게임씬에서 룸으로 이동
        ReadyInfo,
        RequestRoomInfo
    }

    public enum ProtocolRoomPrivatePublic
    {
        Private, Public
    };

    public enum ProtocolCharacterImageNameIndex
    {
        Tofu, Mandu, Tangsuyuk
    }

    public enum ProtocolReady
    {
        NotReady, Ready
    }

    public enum ProtocolTagNull
    {
        Null = -1
    }

    // 이후 밑으로는 대상 Tag 인덱스 
    public enum ProtocolCharacterTagIndex   // CharacterImageTag 배열과 CharacterNameTag 배열의 인덱스
    {
        Red01, Blue01, Red02, Blue02, Red03, Blue03
    }

    public enum ProtocolMessageTag
    {
        Text
    }

    public enum ProtocolFrontMenuTag
    {
        LoginMenu, JoinMenu, GuestMenu, CancleMenu
    }

    public enum ProtocolChannelMenuTag
    {
        MatchingStart, MatchingCancel
    }

    public enum ProtocolSceneName
    {
        StartScene, FrontScene, ChannelScene, RoomScene, MainScene
    }

    //public enum ProtocolSceneName
    //{
    //    FrontScene, ChannelScene, RoomScene, TestScene
    //}

    public enum ProtocolRoomSceneObj
    {
        Room, ButtonTofu, ButtonMandu, ButtonTangsuyuk, ButtonBack, ButtonReady, ButtonLockCharacter, ButtonLockExit,
        RoomInfoPanel
    }

    public enum ProtocolTeamAmount
    {
        OneTeam, TwoTeam, ThreeTeam
    };


    public enum State
    {
        ClientStart,
        ClientNone, ClientFrontMenu/*front씬에서의 기본 상태*/,
        ClientLogin/*login을 선택한 상태*/, ClientJoin/*회원가입을 선택한 상태*/, ClientGuest/*guest 로그인 상태*/,
        ClientChannelMenu/*채널씬에서의 기본 상태*/,
        ClientMakeRoom, ClientOption,
        ClientGame,/*0926추가됨*/
        ClientRequestGaemReady, ClientReady,       // 쌍으로 세트임
        ClientRequestGaemNotReady, ClientNotReady, ClientNotAllReady,/*룸에서의 기본 상태*/ // 1001추가됨
        ClientRequestMatching, ClientMatching,
        ClientRequestCancleMactching, /*채널 기본*/
        ClientRequestCharacterChange, /*룸기본*/
        ClientRequestBackExit, /*씬 기본*/
        ClientRequestMakeRoom, /*room만들기 신청 완료*/
        ClientEnterSpecialRoom, // 방입장 버튼 누른 상태
        ClientRequestSpecialEnterRoom, // 지정방 입장 요청중
        ClientFailEnterRoom
    }

    public enum SoundClip
    {
        Click, RollOver
    }
    //enum ProtocolTeam
    //{
    //    Red, Blue
    //}

    static public class ConstValue
    {
        public const string ServerIP_TextName = "Text/ServerIPInfo.txt";
        public const string ServerPort_TextName = "Text/ServerPortInfo.txt";
        public const int BufSizeRecv = 1024;
        public const int BufSizeSend = 1024;   
        //public const int BufSizeTag = 64;  // 오브젝트 Tag값
        public const int BufSizeValue = 128; // 채팅 메세지, 혹은 값
        public const int CharacterLimitChatting = 40; // 채팅 InputField 글자수 제한
        public const int CharacterLimitID = 8; //  로그인 id 글자수 제한
        public const int CharacterLimitPW = 15; // 로그인 pw 글자수 제한
        public const int CharacterLimitRoomNumber = 4; // 방입장 요청 방번호 글자수 제한
        public const int CharacterLimitGuestName = CharacterLimitID; // Guest로그인 name 글자수 제한
        public const int IntSize = 4;
        public const int ChannelSceneCharacterKind = 4;
        public const int MaxPlayGame = 6; // 각 방에 최대 6명이서 플레이
        public static readonly string[] ProtocolCharacterImageName = { "Tofu", "Mandu", "Tangsuyuk" };
        public static readonly string[] ProtocolCharacterTagIndexImage = { "RedImage01", "BlueImage01", "RedImage02", "BlueImage02", "RedImage03", "BlueImage03" };
        public static readonly string[] ProtocolCharacterTagIndexName = { "RedName01", "BlueName01", "RedName02", "BlueName02", "RedName03", "BlueName03" };
        public static readonly string[] ProtocolCharacterTagIndexReady = { "RedReadyImage01", "BlueReadyImage01", "RedReadyImage02", "BlueReadyImage02", "RedReadyImage03", "BlueReadyImage03" };
        public static readonly string[] ProtocolCharacterTagIndexNameImage = { "RedNameImage01", "BlueNameImage01", "RedNameImage02", "BlueNameImage02", "RedNameImage03", "BlueNameImage03" };
        public static readonly string[] ProtocolCharacterTagIndexMyMark = { "RedMy01", "BlueMy01", "RedMy02", "BlueMy02", "RedMy03", "BlueMy03" };
        public static readonly string[] ProtocolMessageTag = { "TextView" };
        public static readonly string[] ProtocolSceneName = { "StartScene", "FrontScene", "ChannelScene", "RoomScene", "Main" };
        //public static readonly string[] ProtocolSceneName = { "FrontScene", "ChannelScene", "RoomScene", "TestScene" };
        public const int CharacterKind = 3;
        public const string NoticeReadyNoChangeCharacter = "준비 상태일 때는 캐릭터 변경이 불가능합니다.";
        public const string NoticeReadyNoBackExit = "준비 상태일 때는 나갈 수 없습니다.";
        public const string NoticeNotReadyState = "변화가 발생하여 준비가 풀렸습니다.";
        //public const string NoticeReadyNoChangeCharacter = "이미 요청중이거나 준비 상태이므로 캐릭터를 변경할 수 없습니다. 먼저 준비를 풀어주세요.";
        //public const string NoticeReadyNoBackExit = "이미 요청중이거나 준비 상태이므로 방을 나갈 수 없습니다. 먼저 준비를 풀어주세요.";
        //public const string NoticeNotReadyState = "변화가 발생하여 준비가 풀렸습니다. 다시 준비 해주세요.";
        public static readonly string[] InfoPWText = { "공개방 상태이기 때문에 입력하실 수 없습니다.", "영어,숫자 15글자" };
        public const string RoomPWNone = "None";
        public const int WrongValue = -1;
        public const float ChatScrollbarButtonMoveValue = 0.05f;

        // 몇자리 숫자인지 구하기
        public static int CalcCipher(int number)
        {
            if (0 > number)
                return ConstValue.WrongValue;

            int result = 0;
            while (number > 0)
            {
                number /= 10;
                ++result;
            }
            return result;
        }

        public static string IntToAlphabet(int number, int maxCipher)
        {
            int numberCipher = 0;
            char[] result = new char[10];
            numberCipher = CalcCipher(number);
            if (WrongValue == numberCipher)
            {
                return "";
            }
            if (maxCipher < numberCipher)
            {
                return "";
            }
            int zeroCount = maxCipher - numberCipher; // '0'이 채워지는 갯수
            int validCount = maxCipher - zeroCount; // 유효 숫자가 채워지는 갯수
            string temp = "";
            for (int cipher = 0; cipher < zeroCount; ++cipher)
            {
                result[cipher] = '0';
            }
            temp = number.ToString();
            if (validCount > temp.Length)
                return "";
            int tempIndex = 0;
            for (int cipher = zeroCount; cipher < maxCipher; ++cipher)
            {
                result[cipher] = temp[tempIndex];
                ++tempIndex;
            }
            result[maxCipher] = '\0';
            return new string(result);
        }
    }





}