﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NBitcoin.Tests
{
	public partial class NodeDownloadData
	{
		public class BitcoinNodeDownloadData
		{
			public NodeDownloadData v0_13_1 = new NodeDownloadData()
			{
				Version = "0.13.1",
				Linux = new NodeOSDownloadData()
				{
					Archive = "bitcoin-{0}-x86_64-linux-gnu.tar.gz",
					DownloadLink = "https://bitcoincore.org/bin/bitcoin-core-{0}/bitcoin-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "bitcoin-{0}/bin/bitcoind",
					Hash = "2293de5682375b8edfde612d9e152b42344d25d3852663ba36f7f472b27954a4"
				},
				Mac = new NodeOSDownloadData()
				{
					Archive = "bitcoin-{0}-osx64.tar.gz",
					DownloadLink = "https://bitcoincore.org/bin/bitcoin-core-{0}/bitcoin-{0}-osx64.tar.gz",
					Executable = "bitcoin-{0}/bin/bitcoind",
					Hash = "499be4f48c933d92c43468ee2853dddaba4af7e1a17f767a85023b69a21b6e77"
				},
				Windows = new NodeOSDownloadData()
				{
					Executable = "bitcoin-{0}/bin/bitcoind.exe",
					DownloadLink = "https://bitcoincore.org/bin/bitcoin-core-{0}/bitcoin-{0}-win32.zip",
					Archive = "bitcoin-{0}-win32.zip",
					Hash = "fcf6089fc013b175e3c5e32580afb3cb4310c62d2e133e992b8a9d2e0cbbafaa"
				}
			};

			public NodeDownloadData v0_16_3 = new NodeDownloadData()
			{
				Version = "0.16.3",
				Linux = new NodeOSDownloadData()
				{
					Archive = "bitcoin-{0}-x86_64-linux-gnu.tar.gz",
					DownloadLink = "https://bitcoincore.org/bin/bitcoin-core-{0}/bitcoin-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "bitcoin-{0}/bin/bitcoind",
					Hash = "5d422a9d544742bc0df12427383f9c2517433ce7b58cf672b9a9b17c2ef51e4f"
				},
				Mac = new NodeOSDownloadData()
				{
					Archive = "bitcoin-{0}-osx64.tar.gz",
					DownloadLink = "https://bitcoincore.org/bin/bitcoin-core-{0}/bitcoin-{0}-osx64.tar.gz",
					Executable = "bitcoin-{0}/bin/bitcoind",
					Hash = "78c3bff3b619a19aed575961ea43cc9e142959218835cf51aede7f0b764fc25d"
				},
				Windows = new NodeOSDownloadData()
				{
					Executable = "bitcoin-{0}/bin/bitcoind.exe",
					DownloadLink = "https://bitcoincore.org/bin/bitcoin-core-{0}/bitcoin-{0}-win64.zip",
					Archive = "bitcoin-{0}-win64.zip",
					Hash = "52469c56222c1b5344065ef2d3ce6fc58ae42939a7b80643a7e3ee75ec237da9"
				}
			};
		}

		public class LitecoinNodeDownloadData
		{
			public NodeDownloadData v0_14_2 = new NodeDownloadData()
			{
				Version = "0.14.2",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/win/litecoin-{0}-win64.zip",
					Archive = "litecoin-{0}-win64.zip",
					Executable = "litecoin-{0}/bin/litecoind.exe",
					Hash = "c47b196a45f64dbfc9d13b66b50d4da82a263d95b36577e64b31c37590f718b2"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/linux/litecoin-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "litecoin-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "litecoin-{0}/bin/litecoind",
					Hash = "05f409ee57ce83124f2463a3277dc8d46fca18637052d1021130e4deaca07b3c"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/osx/litecoin-{0}-osx64.tar.gz",
					Archive = "litecoin-{0}-osx64.tar.gz",
					Executable = "litecoin-{0}/bin/litecoind"
				}
			};

			public NodeDownloadData v0_15_1 = new NodeDownloadData()
			{
				Version = "0.15.1",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/win/litecoin-{0}-win64.zip",
					Archive = "litecoin-{0}-win64.zip",
					Executable = "litecoin-{0}/bin/litecoind.exe",
					Hash = "eae66242ef66ee22f403ade0c2795ff74f6654bf3fc546e99bde2e6e4c9e148f"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/linux/litecoin-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "litecoin-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "litecoin-{0}/bin/litecoind",
					Hash = "77062f7bad781dd6667854b3c094dbf51094b33405c6cd25c36d07e0dd5e92e5"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/osx/litecoin-{0}-osx64.tar.gz",
					Archive = "litecoin-{0}-osx64.tar.gz",
					Executable = "litecoin-{0}/bin/litecoind",
					Hash = "2bb565a77779be4ed5b186c93891bc0a12352c94316a1fc44388898f7afb7bc2"
				}
			};
		}

		public class ViacoinNodeDownloadData
		{
			public NodeDownloadData v0_15_2 = new NodeDownloadData()
			{
				Version = "0.15.2",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/viacoin/viacoin/releases/download/v{0}/viacoin-{0}-win64.zip",
					Archive = "viacoin-{0}-win64.zip",
					Executable = "viacoin-{0}/bin/viacoind.exe",
					Hash = "79e1d052890dae7531b782046ee4af4851778099121442b219d0605bee486789"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/viacoin/viacoin/releases/download/v{0}/viacoin-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "viacoin-{0}-linux64.tar.gz",
					Executable = "viacoin-{0}/bin/viacoind",
					Hash = "bdbd432645a8b4baadddb7169ea4bef3d03f80dc2ce53dce5783d8582ac63bab"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/viacoin/viacoin/releases/download/v{0}/viacoin-{0}-osx64.tar.gz",
					Archive = "viacoin-{0}-osx64.tar.gz",
					Executable = "viacoin-{0}/bin/viacoind",
					Hash = "b2b0ac9cfb354a017df4271a312f604a67d9e7bc4450f796a20cebd15425c052"
				}
			};
		}

		public class BCashNodeDownloadData
		{
			public NodeDownloadData v0_16_2 = new NodeDownloadData()
			{
				Version = "0.16.2",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.bitcoinabc.org/{0}/win/bitcoin-abc-{0}-win64.zip",
					Archive = "bitcoin-abc-{0}-win64.zip",
					Executable = "bitcoin-abc-{0}/bin/bitcoind.exe",
					Hash = "af022ccdb7d55fdffd1ddddabc2bcde9d72614a4c8412a74456954bacac0e729"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.bitcoinabc.org/{0}/linux/bitcoin-abc-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "bitcoin-abc-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "bitcoin-abc-{0}/bin/bitcoind",
					Hash = "5eeadea9c23069e08d18e0743f4a86a9774db7574197440c6d795fad5cad2084"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.bitcoinabc.org/{0}/osx/bitcoin-abc-{0}-osx64.tar.gz",
					Archive = "bitcoin-abc-{0}-osx64.tar.gz",
					Executable = "bitcoin-abc-{0}/bin/bitcoind",
					Hash = "5a655ddd8eb6b869b902780efe4ec12de24bbede3f6bf2edc3922048928053e5"
				},
			};
		}

		public class FeathercoinNodeDownloadData
		{
			public NodeDownloadData v0_16_0 = new NodeDownloadData()
			{
				Version = "0.16.0",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://downloads.feathercoin.com/feathercoin-{0}.zip",
					Archive = "feathercoin-{0}-win64.zip",
					Executable = "feathercoin-{0}/bin/feathercoind.exe",
					Hash = "5BA572C4283E8C4C0332A8072C82B4C8FD6CADD0D15E6400BA1C0C2991575155"
                },
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "http://downloads.feathercoin.com/feathercoin-0.16.0-x86_64-linux-gnu.tar.gz",
					Archive = "feathercoin-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "feathercoin-{0}/bin/feathercoind",
					Hash = "5673DA0CE1141D5417D6EE502DAD8741F36100CDF89B4F67A525475E9EB435DE"
                },
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "http://downloads.feathercoin.com/feathercoin-{0}-osx64.tar.gz",
					Archive = "feathercoin-{0}-osx64.tar.gz",
					Executable = "feathercoin-{0}/bin/feathercoind",
					Hash = "E6ECE15424DDD83E3FAC64F9A0786AD40F8D89A24ECDC6285353435CD46EEBB1"
                }
			};
		}

		public class DogecoinNodeDownloadData
		{
			public NodeDownloadData v1_10_0 = new NodeDownloadData()
			{
				Version = "1.10.0",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/dogecoin/dogecoin/releases/download/v{0}/dogecoin-{0}-win64.zip",
					Archive = "dogecoin-{0}-win64.zip",
					Executable = "dogecoin-{0}/bin/dogecoind.exe",
					Hash = "e3a2aa652cb35465d9727b51d1b91094881e6c099883955e9d275add2e26f0ce"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/dogecoin/dogecoin/releases/download/v{0}/dogecoin-{0}-linux64.tar.gz",
					Archive = "dogecoin-{0}-linux64.tar.gz",
					Executable = "dogecoin-{0}/bin/dogecoind",
					Hash = "2e5b61842695d74ebcd30f21014cf74b6265f0f7756e9f140f031259bb3cd656"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/dogecoin/dogecoin/releases/download/v{0}/dogecoin-{0}-osx-signed.dmg",
					Archive = "dogecoin-{0}-osx64.tar.gz",
					Executable = "dogecoin-{0}/bin/dogecoind",
					Hash = "be854af97efecf30ee18ed846a3bf3a780a0eb0e459a49377d7a8261c212b322"
				}
			};
		}

		public class DashNodeDownloadData
		{
			public NodeDownloadData v0_12_2 = new NodeDownloadData()
			{
				Version = "0.12.2.3",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/dashpay/dash/releases/download/v{0}/dashcore-{0}-win64.zip",
					Archive = "dashcore-{0}-win64.zip",
					Executable = "dashcore-0.12.2/bin/dashd.exe",
					Hash = "04e95d11443d785ad9d98b04fd2313ca96d937e424be80f639b73846304d154c"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/dashpay/dash/releases/download/v{0}/dashcore-{0}-linux64.tar.gz",
					Archive = "dashcore-{0}-linux64.tar.gz",
					Executable = "dashcore-0.12.2/bin/dashd",
					Hash = "8b7c72197f87be1f5d988c274cac06f6539ddb4591a578bfb852a412022378f2"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/dashpay/dash/releases/download/v{0}/dashcore-{0}-osx.dmg",
					Archive = "dashcore-{0}-osx.dmg",
					Executable = "dashcore-0.12.2/bin/dashd",
					Hash = "90ca27d6733df6fc69b0fc8220f2315623fe5b0cbd1fe31f247684d51808cb81"
				}
			};
		}

		public class DystemNodeDownloadData
		{
			public NodeDownloadData v1_0_9_9 = new NodeDownloadData()
			{
				Version = "1.0.9.9",
				Windows = new NodeOSDownloadData()
				{//
					DownloadLink = "https://github.com/Dystem/dystem-core/releases/download/v{0}/dystem-qt-v{0}.exe",
					Archive = "",
					Executable = "dystemd.exe",
					Hash = "1cf1f317aaae6e8edf520d2439f9c950aafb01bd5b46c399c8582524c59273dc"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/Dystem/dystem-core/releases/download/v{0}/dystemd.tar.gz",
					Archive = "dystemd.tar.gz",
					Executable = "dystemd",
					//Hash = "8b7c72197f87be1f5d988c274cac06f6539ddb4591a578bfb852a412022378f2"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/Dystem/dystem-core/releases/download/v{0}/DYSTEM-Qt.dmg",
					Archive = "DYSTEM-Qt.dmg",
					Executable = "dystemd",
					//Hash = "90ca27d6733df6fc69b0fc8220f2315623fe5b0cbd1fe31f247684d51808cb81"
				}
			};
		}

		public class MogwaiNodeDownloadData
		{
			public NodeDownloadData v0_12_2 = new NodeDownloadData()
			{
				Version = "0.12.2.4",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/mogwaicoin/mogwai/releases/download/v{0}/mogwaicore-{0}-win64.zip",
					Archive = "mogwaicore-{0}-win64.zip",
					Executable = "mogwaicore-0.12.2/bin/mogwaid.exe",
					Hash = "af830999026809416cf5b93d840e6e90ce8af0dc61738bd9bf1c5f059439b0a6"
                },
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/mogwaicoin/mogwai/releases/download/v{0}/mogwaicore-{0}-linux64.tar.gz",
					Archive = "mogwaicore-{0}-linux64.tar.gz",
					Executable = "mogwaicore-0.12.2/bin/mogwaid",
					Hash = "8b7c72197f87be1f5d988c274cac06f6539ddb4591a578bfb852a412022378f2"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/mogwaicoin/mogwai/releases/download/v{0}/mogwaicore-{0}-osx.dmg",
					Archive = "mogwaicore-{0}-osx.dmg",
					Executable = "mogwaicore-0.12.2/bin/mogwaid",
					Hash = "90ca27d6733df6fc69b0fc8220f2315623fe5b0cbd1fe31f247684d51808cb81"
				}
			};
		}
		public class BGoldNodeDownloadData
		{
			public NodeDownloadData v0_15_0 = new NodeDownloadData()
			{
				Version = "0.15.0",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/BTCGPU/BTCGPU/releases/download/v{0}.2/bitcoin-gold-{0}-win64.zip",
					Archive = "bitcoin-gold-{0}-win64.zip",
					Executable = "bitcoin-gold-{0}/bin/bgoldd.exe",
					Hash = "497dba65c2047bc374532d83f91bf38bc7b44eae2eca36b9a375b59abfe9e6fc"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/BTCGPU/BTCGPU/releases/download/v{0}.2/bitcoin-gold-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "bitcoin-gold-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "bitcoin-gold-{0}/bin/bgoldd",
					Hash = "c49fa0874333837526cf1b4fce5b58abe6437b48e64dcf095654e6317e1f66a3"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/BTCGPU/BTCGPU/releases/download/v{0}.2/bitcoin-gold-{0}-osx64.tar.gz",
					Archive = "bitcoin-gold-{0}-osx64.tar.gz",
					Executable = "bitcoin-gold-{0}/bin/bgoldd",
					Hash = "87bb6dd288ffa3d0cd753a8013a177a2e48b63ddf10f3593634388b59a60c45b"
				},
			};
		}

		public class PolisNodeDownloadData
		{
			public NodeDownloadData v1_3_0 = new NodeDownloadData()
			{
				Version = "1.3.0",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/polispay/polis/releases/download/v{0}/poliscore-{0}-win64.zip",
					Archive = "poliscore-{0}-win64.zip",
					Executable = "poliscore-1.3.0/bin/polisd.exe",
					Hash = "eec3d9b0c721d690139bc9ac11344ba370245c4ade5d6ec6750eda27493b2390"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/polispay/polis/releases/download/v{0}/poliscore-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "poliscore-{0}-linux64.tar.gz",
					Executable = "poliscore-1.3.0/bin/polisd",
					Hash = "50c3599645fbcfdfa35f4704ed742bbb5fa1ca432067f9b2368deea9784ec771"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/polispay/polis/releases/download/v{0}/poliscore-{0}-osx.dmg",
					Archive = "poliscore-{0}-osx.dmg",
					Executable = "poliscore-1.3.0/bin/polisd",
					Hash = "2d67048a8e51d6c1384752cfde6a3562b1b1ba250fce28020e8afe894a9b5afe"
				}
			};
		}

		public class BitcoreNodeDownloadData
		{
			public NodeDownloadData v0_15_1 = new NodeDownloadData()
			{
				Version = "0.15.1.0",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/LIMXTEC/BitCore/releases/download/{0}/Windows.zip",
					Archive = "Windows.zip",
					Executable = "Windows/bitcored.exe",
					Hash = "9d884f0a9221060172101997e15d58ca63db88ad51907fe89b31b55348b10f97"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/LIMXTEC/BitCore/releases/download/{0}/linux.Ubuntu.16.04.regtest-noqt.tar.gz",
					Archive = "linux.Ubuntu.16.04.regtest-noqt.tar.gz",
					Executable = "bitcored",
					Hash = "ecbffb6ed6bbe1209e78246c1ae6e6f55e375c7ffbd82fdc40ff95db350ce5c6"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/LIMXTEC/BitCore/releases/download/{0}/bitcore-qt.dmg",
					Archive = "bitcore-qt.dmg",
					Executable = "bitcored",
					Hash = "929005100984972bb66253278826af4698720d1f01fd6429ac3ab2b19f811f97"
				}
			};
		}

		public class MonacoinNodeDownloadData
		{
			public NodeDownloadData v0_15_1 = new NodeDownloadData()
			{
				Version = "0.15.1",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/monacoinproject/monacoin/releases/download/monacoin-{0}/monacoin-{0}-win64.zip",
					Archive = "monacoin-{0}-win64.zip",
					Executable = "monacoin-{0}/bin/monacoind.exe",
					Hash = "420cba3c5e70cc913c2cacab9162e8fd1408fc2aaa345b04d3f44615c63d7b17"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/monacoinproject/monacoin/releases/download/monacoin-{0}/monacoin-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "monacoin-{0}-linux64.tar.gz",
					Executable = "monacoin-{0}/bin/monacoind",
					Hash = "8199f92d4296ea99891db34f5d779d7e95a2338425544b82b04fd8b427dae905"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/monacoinproject/monacoin/releases/download/monacoin-{0}/monacoin-{0}-osx-unsigned.dmg",
					Archive = "monacoin-{0}-osx.dmg",
					Executable = "monacoin-{0}/bin/monacoind",
					Hash = "d19cc2cc12732c49351add23075c4f7a4ec92ee04874ec7037429dc4f9f1c058"
				}
			};
		}

        public class UfoNodeDownloadData
        {
            public NodeDownloadData v0_16_0 = new NodeDownloadData()
            {
                Version = "0.16.0",
                Windows = new NodeOSDownloadData()
                {
                    DownloadLink = "https://downloads.ufobject.com/ufo-0.16.0.zip",
                    Archive = "UFO-{0}-win64.zip",
                    Executable = "UFO-{0}/bin/ufod.exe",
                    Hash = "B06D8564CF2BF95EDD4AECEB3F725C12FB18A31398E59B48A242AED210261FAE"
                },
                Linux = new NodeOSDownloadData()
                {
                    DownloadLink = "https://downloads.ufobject.com/ufo-0.16.0-x86_64-linux-gnu.tar.gz",
                    Archive = "UFO-{0}-linux64.tar.gz",
                    Executable = "UFO-{0}/bin/ufod",
                    Hash = "2A0F4ED78EA58C232CCEA6DDD4EB36F766C72663D1DF9B6FDA0CB39143FE0F60"
                },
                Mac = new NodeOSDownloadData()
                {
                    DownloadLink = "https://downloads.ufobject.com/ufo-0.16.0-osx64.tar.gz",
                    Archive = "UFO-{0}-osx.dmg",
                    Executable = "UFO-{0}/bin/ufod",
                    Hash = "5CC7E5F742584BAD0CADD516B09C93566D38B42C352F21D521C84C9490088ACB"
				}
			};
		}

		public class GroestlcoinNodeDownloadData
		{
			public NodeDownloadData v2_16_0 = new NodeDownloadData()
			{
				Version = "2.16.0",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/Groestlcoin/groestlcoin/releases/download/v{0}/groestlcoin-{0}-x86_64-w64-mingw32.zip",
					Archive = "groestlcoin-{0}-x86_64-w64-mingw32.zip",
					Executable = "GRS-{0}\\groestlcoind.exe",
					Hash = "327aaee189255f2722736a426732a0f38fef90bae6495f42fd148138523c586c",
					CreateFolder = "GRS-{0}"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/Groestlcoin/groestlcoin/releases/download/v{0}/groestlcoin-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "groestlcoin-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "GRS-{0}/groestlcoind",
					Hash = "4e7683bbc6f3b7899761d1360f52a91f417e2b7e6c56b75b522d95b86ca46628",
					CreateFolder = "GRS-{0}"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/Groestlcoin/groestlcoin/releases/download/v{0}/groestlcoin-{0}-x86_64-apple-darwin11.tar.gz",
					Archive = "groestlcoin-{0}-x86_64-apple-darwin11.tar.gz",
					Executable = "GRS-{0}/groestlcoind",
					Hash = "5ff6e5a509e0c69f4a832bd3c40a1a93f80a68bc5f55a0b5d517716fb123164e",
					CreateFolder = "GRS-{0}"
				}
			};
		}

		public class ZclassicNodeDownloadData
		{
			public NodeDownloadData v1_0_14 = new NodeDownloadData()
			{
				Version = "1.0.14",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/z-classic/zclassic/releases/download/v{0}/zclassic-v{0}-win.zip",
					Archive = "zclassic-v{0}-win.zip",
					Executable = "zclassic-{0}/bin/zcld.exe",
					Hash = "99923ACC9D45609FDD4098AF8033542A34E41840091C9121C326571889811A2A"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/z-classic/zclassic/releases/download/v{0}/zclassic-v{0}-linux.tar.gz",
					Archive = "zclassic-v{0}-linux.tar.gz",
					Executable = "zclassic-{0}/bin/zcld",
					Hash = "51e49a81f8493923c08e3cdd72b253bbcc10fe582e97f6926e6267a4f337b696"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/z-classic/zclassic/releases/download/v{0}/zclassic-v{0}-mac.zip",
					Archive = "zclassic-v{0}-mac.zip",
					Executable = "zclassic-{0}/bin/zcld",
					Hash = ""
				},
			};
		}

		public static GroestlcoinNodeDownloadData Groestlcoin
		{
			get; set;
		} = new GroestlcoinNodeDownloadData();

		public static MogwaiNodeDownloadData Mogwai
		{
			get; set;
		} = new MogwaiNodeDownloadData();
		public static BitcoinNodeDownloadData Bitcoin
		{
			get; set;
		} = new BitcoinNodeDownloadData();

		public static LitecoinNodeDownloadData Litecoin
		{
			get; set;
		} = new LitecoinNodeDownloadData();

		public static ViacoinNodeDownloadData Viacoin
		{
			get; set;
		} = new ViacoinNodeDownloadData();

		public static BCashNodeDownloadData BCash
		{
			get; set;
		} = new BCashNodeDownloadData();

		public static FeathercoinNodeDownloadData Feathercoin
		{
			get; set;
		} = new FeathercoinNodeDownloadData();

		public static DogecoinNodeDownloadData Dogecoin
		{
			get; set;
		} = new DogecoinNodeDownloadData();

		public static DashNodeDownloadData Dash
		{
			get; set;
		} = new DashNodeDownloadData();

		public static BGoldNodeDownloadData BGold
		{
			get; set;
		} = new BGoldNodeDownloadData();

		public static PolisNodeDownloadData Polis
		{
			get; set;
		} = new PolisNodeDownloadData();

		public static MonacoinNodeDownloadData Monacoin
		{
			get; set;
		} = new MonacoinNodeDownloadData();

		public static UfoNodeDownloadData Ufo
		{
			get; set;
		} = new UfoNodeDownloadData();

		public static BitcoreNodeDownloadData Bitcore
		{
			get; set;
		} = new BitcoreNodeDownloadData();

		public static ZclassicNodeDownloadData Zclassic
		{
			get; set;
		} = new ZclassicNodeDownloadData();
	}
}
