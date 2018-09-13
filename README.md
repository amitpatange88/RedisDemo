<h1>Redis</h1>
<div class="Box-body p-6">
        <article class="markdown-body entry-content" itemprop="text"><p><a href="https://ci.appveyor.com/project/MSOpenTech-lab/redis" rel="nofollow"><img src="https://camo.githubusercontent.com/4baaa0849fd16beb5fb6b7897bc69aae7264bad8/687474703a2f2f696d672e736869656c64732e696f2f6170707665796f722f63692f4d534f70656e546563682d6c61622f72656469732e7376673f7374796c653d666c61742d737175617265" alt="Windows Status" data-canonical-src="http://img.shields.io/appveyor/ci/MSOpenTech-lab/redis.svg?style=flat-square" style="max-width:100%;"></a> <a href="http://www.nuget.org/packages/redis-64/" rel="nofollow"><img src="https://camo.githubusercontent.com/149b11a2996964bbe899bd859089da9175e3a14c/687474703a2f2f696d672e736869656c64732e696f2f6e756765742f762f72656469732d36342e7376673f7374796c653d666c61742d737175617265" alt="NuGet version" data-canonical-src="http://img.shields.io/nuget/v/redis-64.svg?style=flat-square" style="max-width:100%;"></a> <a href="http://www.chocolatey.org/packages/redis-64/" rel="nofollow"><img src="https://camo.githubusercontent.com/c51d6e566d83030eb15ccdc4c831702565a0f666/687474703a2f2f696d672e736869656c64732e696f2f63686f636f6c617465792f762f72656469732d36342e7376673f7374796c653d666c61742d737175617265" alt="Chocolatey version" data-canonical-src="http://img.shields.io/chocolatey/v/redis-64.svg?style=flat-square" style="max-width:100%;"></a> <a href="http://www.chocolatey.org/packages/redis-64/" rel="nofollow"><img src="https://camo.githubusercontent.com/ad56c47569a508b79c7a01195131e7d6f8c65d1e/687474703a2f2f696d672e736869656c64732e696f2f63686f636f6c617465792f64742f72656469732d36342e7376673f7374796c653d666c61742d737175617265" alt="Chocolatey downloads" data-canonical-src="http://img.shields.io/chocolatey/dt/redis-64.svg?style=flat-square" style="max-width:100%;"></a></p>
<h2><a id="user-content-redis-on-windows" class="anchor" aria-hidden="true" href="#redis-on-windows"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Redis on Windows</h2>
<ul>
<li>This is a port for Windows based on <a href="https://github.com/antirez/redis">Redis</a>.</li>
<li>We officially support the 64-bit version only. Although you can build the 32-bit version from source if desired.</li>
<li>You can download the latest unsigned binaries and the unsigned MSI installer from the <a href="http://github.com/MSOpenTech/redis/releases" title="Release page">release page</a>.</li>
<li>For releases prior to 2.8.17.1, the binaries can found in a zip file inside the source archive, under the bin/release folder.</li>
<li>Signed binaries are available through <a href="https://www.nuget.org/packages/Redis-64/" rel="nofollow">NuGet</a> and <a href="https://chocolatey.org/packages/redis-64" rel="nofollow">Chocolatey</a>.</li>
<li>Redis can be installed as a Windows Service.</li>
</ul>
<h2><a id="user-content-windows-specific-changes" class="anchor" aria-hidden="true" href="#windows-specific-changes"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Windows-specific changes</h2>
<ul>
<li>There is a replacement for the UNIX fork() API that simulates the copy-on-write behavior using a memory mapped file on 2.8. Version 3.0 is using a similar behavior but dropped the memory mapped file in favor of the system paging file.</li>
<li>In 3.0 we switch the default memory allocator from dlmalloc to jemalloc that is supposed to do a better job at managing the heap fragmentation.</li>
<li>Because Redis makes some assumptions about the values of file descriptors, we have built a virtual file descriptor mapping layer.</li>
</ul>
<h2><a id="user-content-redis-release-notes" class="anchor" aria-hidden="true" href="#redis-release-notes"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Redis release notes</h2>
<p>There are two current active branches: 2.8 and 3.0.</p>
<ul>
<li>Redis on UNIX <a href="https://raw.githubusercontent.com/antirez/redis/2.8/00-RELEASENOTES" rel="nofollow">2.8 release notes</a></li>
<li>Redis on Windows <a href="https://raw.githubusercontent.com/MSOpenTech/redis/2.8/Redis%20on%20Windows%20Release%20Notes.md" rel="nofollow">2.8 release notes</a></li>
<li>Redis on UNIX <a href="https://raw.githubusercontent.com/antirez/redis/3.0/00-RELEASENOTES" rel="nofollow">3.0 release notes</a></li>
<li>Redis on Windows <a href="https://raw.githubusercontent.com/MSOpenTech/redis/3.0/Redis%20on%20Windows%20Release%20Notes.md" rel="nofollow">3.0 release notes</a></li>
</ul>
<h2><a id="user-content-how-to-configure-and-deploy-redis-on-windows" class="anchor" aria-hidden="true" href="#how-to-configure-and-deploy-redis-on-windows"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>How to configure and deploy Redis on Windows</h2>
<ul>
<li><a href="https://github.com/MSOpenTech/redis/wiki/Memory-Configuration" title="Memory Configuration">Memory Configuration for 2.8</a></li>
<li><a href="https://github.com/MSOpenTech/redis/wiki/Memory-Configuration-For-Redis-3.0" title="Memory Configuration">Memory Configuration for 3.0</a></li>
<li><a href="https://raw.githubusercontent.com/MSOpenTech/redis/3.0/Windows%20Service%20Documentation.md" title="Windows Service Documentation" rel="nofollow">Windows Service Documentation</a></li>
<li><a href="https://raw.githubusercontent.com/MSOpenTech/redis/2.8/Redis%20on%20Windows.md" title="Redis on Windows" rel="nofollow">Redis on Windows</a></li>
<li><a href="https://raw.githubusercontent.com/MSOpenTech/redis/2.8/Windows%20Service%20Documentation.md" title="Windows Service Documentation" rel="nofollow">Windows Service Documentation</a></li>
</ul>
<h2><a id="user-content-how-to-build-redis-using-visual-studio" class="anchor" aria-hidden="true" href="#how-to-build-redis-using-visual-studio"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>How to build Redis using Visual Studio</h2>
<p>You can use the free <a href="http://www.visualstudio.com/products/visual-studio-community-vs" rel="nofollow">Visual Studio 2013 Community Edition</a>. Regardless which Visual Studio edition you use, make sure you have updated to Update 5, otherwise you will get a "illegal use of this type as an expression" error.</p>
<ul>
<li>
<p>Open the solution file msvs\redisserver.sln in Visual Studio, select a build configuration (Debug or Release) and target (x64) then build.</p>
<p>This should create the following executables in the msvs$(Target)$(Configuration) folder:</p>
<ul>
<li>redis-server.exe</li>
<li>redis-benchmark.exe</li>
<li>redis-cli.exe</li>
<li>redis-check-dump.exe</li>
<li>redis-check-aof.exe</li>
</ul>
</li>
</ul>
<h2><a id="user-content-testing" class="anchor" aria-hidden="true" href="#testing"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Testing</h2>
<p>To run the Redis test suite some manual work is required:</p>
<ul>
<li>The tests assume that the binaries are in the src folder. Use mklink to create a symbolic link to the files in the msvs\x64\Debug|Release folders. You will
need symbolic links for src\redis-server, src\redis-benchmark, src\redis-check-aof, src\redis-check-dump, src\redis-cli, and src\redis-sentinel.</li>
<li>The tests make use of TCL. This must be installed separately.</li>
<li>To run the cluster tests against 3.0, Ruby On Windows is required.</li>
<li>To run the tests you need to have a Unix shell on your machine, or MinGW tools in your path. To execute the tests, run the following command:
"tclsh8.5.exe tests/test_helper.tcl --clients N", where N is the number of parallel clients . If a Unix shell is not installed you may see the
following error message: "couldn't execute "cat": no such file or directory".</li>
<li>By default the test suite launches 16 parallel tests, but 2 is the suggested number.</li>
</ul>
<h2><a id="user-content-code-of-conduct" class="anchor" aria-hidden="true" href="#code-of-conduct"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Code of Conduct</h2>
<p>This project has adopted the <a href="https://opensource.microsoft.com/codeofconduct/" rel="nofollow">Microsoft Open Source Code of Conduct</a>. For more information see the <a href="https://opensource.microsoft.com/codeofconduct/faq/" rel="nofollow">Code of Conduct FAQ</a> or contact <a href="mailto:opencode@microsoft.com">opencode@microsoft.com</a> with any additional questions or comments.</p>
</article>
      </div>
